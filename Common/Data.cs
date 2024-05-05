using PhasmaBuster.Common.Contracts;

namespace PhasmaBuster.Common;

public class Data
{
    public Dictionary<Ghost, List<IEvidence>> GhostEvidences { get; private set; } = new();
    public Dictionary<string, IEvidence> Evidences { get; private set; } = new();
    
    public Data()
    {
        CreateEvidences();
        CreateGhosts();
    }

    private void CreateGhosts()
    {
        CreateGhost(new Ghost()
        {
            Name = "Дух"
        }, new List<string>()
        {
            "ЭМП 5",
            "Рация",
            "Записи в блокноте"
        });
        
        CreateGhost(new Ghost()
        {
            Name = "Банши"
        }, new List<string>()
        {
            "Ультрафиолет",
            "Призрачный огонёк",
            "Лазерный проектор",
            
            "Отпечаток на ультрафиолете",
            "Крик в направленный микрофон",
        });
        
        
        CreateGhost(new Ghost()
        {
            Name = "Тень"
        }, new List<string>()
        {
            "ЭМП 5",
            "Записи в блокноте",
            "Минусовая температура"
        });
        
        CreateGhost(new Ghost()
        {
            Name = "Ёкай",
            Speed = 1.7m
        }, new List<string>()
        {
            "Рация",
            "Призрачный огонёк",
            "Лазерный проектор",
        });
    }

    private void CreateEvidences()
    {
        #region StandartEvidence

        CreateEvidence(new StandartEvidence()
        {
            Name = "ЭМП 5",
            IconName = "radar",
            Sequence = 0
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Отпечаток на ультрафиолете",
            IconName = "fingerprint",
            Sequence = 1
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Записи в блокноте",
            IconName = "note_alt",
            Sequence = 2
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Минусовая температура",
            IconName = "ac_unit",
            Sequence = 3
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Лазерный проектор",
            IconName = "blur_on",
            Sequence = 4
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Призрачный огонёк",
            IconName = "auto_awesome",
            Sequence = 5
        });
        CreateEvidence(new StandartEvidence()
        {
            Name = "Рация",
            IconName = "radio",
            Sequence = 6
        });

        #endregion

        #region HiddenEvidence

        CreateEvidence(new HiddenEvidence()
        {
            Name = "Крик в направленный микрофон"
        });
        
        CreateEvidence(new HiddenEvidence()
        {
            Name = "Следы на соли"
        });

        #endregion

    }

    private void CreateGhost(Ghost ghost, ICollection<string> evidenceNames)
    {
        var evidences = Evidences
            .Where(x => evidenceNames.Contains(x.Key))
            .Select(x => x.Value)
            .ToList();
        
        GhostEvidences.Add(ghost, evidences);
    }
    
    private void CreateEvidence(IEvidence evidence)
    {
        if (evidence.Name != null)
        {
            Evidences.Add(evidence.Name, evidence);
        }
    }
}