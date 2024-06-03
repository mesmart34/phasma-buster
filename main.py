import re
import pandas as pd

prefix = 'PhasmaBusterTranslation'
ghosts = []
evidences = dict()
code = '''using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data;

public class Model
{
    public readonly Dictionary<Evidence, EvidenceState> FilterEvidences = new();
	public readonly List<Evidence> Evidences;
	public readonly List<Ghost> Ghosts;\n\n'''
tabs = 0


class Evidence:
    def __init__(self):
        name = ''
        owner_name = ''
        category = ''
        filter_attribute = ''
        color = ''
        icon_name = ''
        description_file_path = ''
        description_type = ''


class Ghost:
    def __init__(self):
        name = ''
        standard_evidences = []
        sanity = []
        speed = []
        blink = ''
        required_evidence = ''


def convert_to_camel(s):
    s = s.lower().capitalize()
    s = re.sub(r'_(\d+)_', lambda x: x.group(1), s)
    s = re.sub(r'_([a-zA-Z])', lambda x: x.group(1).upper(), s)
    return s


def push():
    global tabs
    tabs += 1


def pop():
    global tabs
    tabs -= 1


def write(line='\n'):
    global code
    code += f'{'\t' * tabs}{line}{'\n'}'


def parse_evidences(evidences_sheet):
    iter = evidences_sheet.iterrows()
    for index, row in iter:
        evidence = Evidence()
        evidence.owner_name = row.iloc[0]
        evidence.name = str(row.iloc[1])
        evidence.category = row.iloc[2]
        evidence.filter_attribute = row.iloc[3]
        evidence.color = row.iloc[4]
        evidence.icon_name = row.iloc[5]
        evidence.description_type = row.iloc[6]
        evidence.description_file_path = row.iloc[7]
        evidences[evidence.name] = evidence


def parse_ghosts(ghosts_sheet):
    iter = ghosts_sheet.iterrows()
    for index, row in iter:
        ghost = Ghost()
        ghost.name = row.iloc[0]
        ghost.standard_evidences = str(row.iloc[1]).split(', ')
        ghost.sanity = str(row.iloc[2]).split(', ')
        ghost.speed = [float(x) for x in str(row.iloc[3]).split(', ')]
        ghost.blink = row.iloc[4]
        ghost.required_evidence = row.iloc[5]
        ghosts.append(ghost)


def parse(file_path):
    dfs = pd.read_excel(file_path, sheet_name=None)
    parse_evidences(dfs['Evidences'])
    parse_ghosts(dfs['Ghosts'])


def write_ghosts():
    evs = list(evidences.values())
    for ghost in ghosts:
        behaviours = list(filter(lambda x: x.category == 'BEHAVIOURS' and x.name.startswith(ghost.name), evs))
        tells = list(filter(lambda x: x.category == 'TELLS' and x.name.startswith(ghost.name), evs))
        write(f'private static readonly Ghost {convert_to_camel(ghost.name)} = new()')
        write('{')
        push()
        write(f'Name = {prefix}.{ghost.name},')
        if str(ghost.required_evidence) != 'nan':
            write(f'RequiredStandardEvidences = [{convert_to_camel(ghost.required_evidence)}],')
        write(f'SpeedValues = [{', '.join(f'{x}m' for x in ghost.speed)}],')
        write(f'SanityValues = [{', '.join(f'{x}m' for x in ghost.sanity)}],')
        write('Evidences = new Dictionary<EvidenceType, List<Evidence>>()')
        write('{')
        push()
        write('{')
        push()
        write(f'EvidenceType.Standard,')
        write('[')
        push()
        for index, se in enumerate(ghost.standard_evidences):
            name = convert_to_camel(se)
            write(f'{name}{',' if index < len(ghost.standard_evidences) - 1 else ''}')
        pop()
        write(']')
        pop()
        write('},')
        if len(behaviours) > 0:
            write('{')
            push()
            write(f'EvidenceType.Behaviours,')
            write(f'[')
            push()
            for index, ev in enumerate(behaviours):
                write(f'{convert_to_camel(ev.name)}{',' if index < len(behaviours) - 1 else ''}')
            pop()
            write(']')
            pop()
            write('},')
        if len(tells) > 0:
            write('{')
            push()
            write(f'EvidenceType.Tells,')
            write(f'[')
            push()
            for index, ev in enumerate(tells):
                write(f'{convert_to_camel(ev.name)}{',' if index < len(tells) - 1 else ''}')
            pop()
            write(']')
            pop()
            write('}')
        pop()
        write('},')
        pop()
        write('};\n')


def write_evidences():
    for evidence in evidences.values():
        write(f'private static readonly Evidence {convert_to_camel(evidence.name)} = new()')
        write('{')
        push()
        write(f'Name = {prefix}.{evidence.name},')
        if evidence.owner_name != 'ALL':
            write(f'Description = new()')
            write('{')
            push()
            write(f'Text = {prefix}.{evidence.name}_D,')
            if str(evidence.description_type) != 'nan':
                write(f'EvidenceDescriptionType = EvidenceDescriptionType.{evidence.description_type},')
            if str(evidence.description_file_path) != 'nan':
                write(f'FilePath = "{evidence.description_file_path}",')
            pop()
            write('},')
        if str(evidence.icon_name) != 'nan':
            write(f'IconName = "{evidence.icon_name}",')
        if str(evidence.color) != 'nan':
            write(f'Color = Color.{evidence.color},')
        write(f'Category = EvidenceType.{convert_to_camel(evidence.category)}')
        pop()
        write('};\n')


if __name__ == "__main__":
    parse('data.xlsx')
    push()
    write_evidences()
    write_ghosts()
    write('public Model()')
    write('{')
    push()
    write('Evidences = new()')
    write('{')
    push()
    for index, ev in enumerate(evidences.keys()):
        write(f'{convert_to_camel(ev)}{',' if index < len(evidences.keys()) else ''}')
    pop()
    write('};')
    write()
    write('Ghosts = new()')
    write('{')
    push()
    for index, ghost in enumerate(ghosts):
        write(f'{convert_to_camel(ghost.name)}{',' if index < len(ghosts) else ''}')
    pop()
    write('};')
    write('''foreach (var baseEvidence in Evidences)
		{
            FilterEvidences.Add(baseEvidence, EvidenceState.Idle);
        }''')
    pop()
    write('}')
    pop()
    write('}')
    output_file = f"Data/Model.cs"
    with open(output_file, 'w') as file:
        file.write(code)
