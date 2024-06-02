using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data;

public class Model
{
    public readonly Dictionary<Evidence, EvidenceState> FilterEvidences = new();
	public readonly List<Evidence> Evidences;
	public readonly List<Ghost> Ghosts;

	private static readonly Evidence Emf5 = new()
	{
		Name = PhasmaBusterTranslation.EMF5,
		IconName = "radar",
		Color = Color.Red,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence Ultraviolet = new()
	{
		Name = PhasmaBusterTranslation.ULTRAVIOLET,
		IconName = "fingerprint",
		Color = Color.Khaki,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence SpiritBox = new()
	{
		Name = PhasmaBusterTranslation.SPIRIT_BOX,
		IconName = "radio",
		Color = Color.Orange,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence Writing = new()
	{
		Name = PhasmaBusterTranslation.WRITING,
		IconName = "note_alt",
		Color = Color.RoyalBlue,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence Freezing = new()
	{
		Name = PhasmaBusterTranslation.FREEZING,
		IconName = "ac_unit",
		Color = Color.SkyBlue,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence Dots = new()
	{
		Name = PhasmaBusterTranslation.DOTS,
		IconName = "blur_on",
		Color = Color.Green,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence GhostOrbs = new()
	{
		Name = PhasmaBusterTranslation.GHOST_ORBS,
		IconName = "auto_awesome",
		Color = Color.White,
		Category = EvidenceType.Standard
	};

	private static readonly Evidence SpiritEv1 = new()
	{
		Name = PhasmaBusterTranslation.SPIRIT_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SPIRIT_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence WraithEv1 = new()
	{
		Name = PhasmaBusterTranslation.WRAITH_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.WRAITH_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence WraithEv2 = new()
	{
		Name = PhasmaBusterTranslation.WRAITH_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.WRAITH_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence PhantomEv1 = new()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence PhantomEv2 = new()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence PhantomEv3 = new()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence PoltergeistEv1 = new()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence PoltergeistEv2 = new()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence PoltergeistEv3 = new()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence PoltergeistEv4 = new()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence BansheeEv1 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV1_D,
			EvidenceDescriptionType = EvidenceDescriptionType.Audio,
			FilePath = "banshee_scream.mp3",
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence BansheeEv2 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence BansheeEv3 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence BansheeEv4 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV4_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence BansheeEv5 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV5,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV5_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence BansheeEv6 = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV6,
		Description = new()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV6_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence JinnEv1 = new()
	{
		Name = PhasmaBusterTranslation.JINN_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.JINN_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence JinnEv2 = new()
	{
		Name = PhasmaBusterTranslation.JINN_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.JINN_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MareEv1 = new()
	{
		Name = PhasmaBusterTranslation.MARE_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MARE_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence MareEv2 = new()
	{
		Name = PhasmaBusterTranslation.MARE_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MARE_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence MareEv3 = new()
	{
		Name = PhasmaBusterTranslation.MARE_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MARE_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence MareEv4 = new()
	{
		Name = PhasmaBusterTranslation.MARE_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MARE_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MareEv5 = new()
	{
		Name = PhasmaBusterTranslation.MARE_EV5,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MARE_EV5_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence RevenantEv1 = new()
	{
		Name = PhasmaBusterTranslation.REVENANT_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.REVENANT_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv1 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv2 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv3 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv4 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV4_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv5 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV5,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV5_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ShadowEv6 = new()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV6,
		Description = new()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV6_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence DemonEv1 = new()
	{
		Name = PhasmaBusterTranslation.DEMON_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEMON_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence DemonEv2 = new()
	{
		Name = PhasmaBusterTranslation.DEMON_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEMON_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence DemonEv3 = new()
	{
		Name = PhasmaBusterTranslation.DEMON_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEMON_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence DemonEv4 = new()
	{
		Name = PhasmaBusterTranslation.DEMON_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEMON_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YureiEv1 = new()
	{
		Name = PhasmaBusterTranslation.YUREI_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YUREI_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence YureiEv2 = new()
	{
		Name = PhasmaBusterTranslation.YUREI_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YUREI_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YureiEv3 = new()
	{
		Name = PhasmaBusterTranslation.YUREI_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YUREI_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YureiEv4 = new()
	{
		Name = PhasmaBusterTranslation.YUREI_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YUREI_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence OniEv1 = new()
	{
		Name = PhasmaBusterTranslation.ONI_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.ONI_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence OniEv2 = new()
	{
		Name = PhasmaBusterTranslation.ONI_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.ONI_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YokaiEv1 = new()
	{
		Name = PhasmaBusterTranslation.YOKAI_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YOKAI_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YokaiEv2 = new()
	{
		Name = PhasmaBusterTranslation.YOKAI_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YOKAI_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence YokaiEv3 = new()
	{
		Name = PhasmaBusterTranslation.YOKAI_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.YOKAI_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence HantuEv1 = new()
	{
		Name = PhasmaBusterTranslation.HANTU_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.HANTU_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence HantuEv2 = new()
	{
		Name = PhasmaBusterTranslation.HANTU_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.HANTU_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence HantuEv3 = new()
	{
		Name = PhasmaBusterTranslation.HANTU_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.HANTU_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence HantuEv4 = new()
	{
		Name = PhasmaBusterTranslation.HANTU_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.HANTU_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence GoryoEv1 = new()
	{
		Name = PhasmaBusterTranslation.GORYO_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.GORYO_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence GoryoEv2 = new()
	{
		Name = PhasmaBusterTranslation.GORYO_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.GORYO_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence GoryoEv3 = new()
	{
		Name = PhasmaBusterTranslation.GORYO_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.GORYO_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence GoryoEv4 = new()
	{
		Name = PhasmaBusterTranslation.GORYO_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.GORYO_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MylingEv1 = new()
	{
		Name = PhasmaBusterTranslation.MYLING_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MYLING_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MylingEv2 = new()
	{
		Name = PhasmaBusterTranslation.MYLING_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MYLING_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence OnryoEv1 = new()
	{
		Name = PhasmaBusterTranslation.ONRYO_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.ONRYO_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence OnryoEv2 = new()
	{
		Name = PhasmaBusterTranslation.ONRYO_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.ONRYO_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence OnryoEv3 = new()
	{
		Name = PhasmaBusterTranslation.ONRYO_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.ONRYO_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence TheTwinsEv1 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence TheTwinsEv2 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence TheTwinsEv3 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence TheTwinsEv4 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence TheTwinsEv5 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV5,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV5_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence TheTwinsEv6 = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS_EV6,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THE_TWINS_EV6_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence RaijuEv1 = new()
	{
		Name = PhasmaBusterTranslation.RAIJU_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.RAIJU_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence RaijuEv2 = new()
	{
		Name = PhasmaBusterTranslation.RAIJU_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.RAIJU_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence RaijuEv3 = new()
	{
		Name = PhasmaBusterTranslation.RAIJU_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.RAIJU_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ObakeEv1 = new()
	{
		Name = PhasmaBusterTranslation.OBAKE_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.OBAKE_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ObakeEv2 = new()
	{
		Name = PhasmaBusterTranslation.OBAKE_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.OBAKE_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ObakeEv3 = new()
	{
		Name = PhasmaBusterTranslation.OBAKE_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.OBAKE_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ObakeEv4 = new()
	{
		Name = PhasmaBusterTranslation.OBAKE_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.OBAKE_EV4_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence ObakeEv5 = new()
	{
		Name = PhasmaBusterTranslation.OBAKE_EV5,
		Description = new()
		{
			Text = PhasmaBusterTranslation.OBAKE_EV5_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence MimicEv1 = new()
	{
		Name = PhasmaBusterTranslation.MIMIC_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MIMIC_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MimicEv2 = new()
	{
		Name = PhasmaBusterTranslation.MIMIC_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MIMIC_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MimicEv3 = new()
	{
		Name = PhasmaBusterTranslation.MIMIC_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MIMIC_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly Evidence MoroiEv1 = new()
	{
		Name = PhasmaBusterTranslation.MOROI_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MOROI_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MoroiEv2 = new()
	{
		Name = PhasmaBusterTranslation.MOROI_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MOROI_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MoroiEv3 = new()
	{
		Name = PhasmaBusterTranslation.MOROI_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MOROI_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence MoroiEv4 = new()
	{
		Name = PhasmaBusterTranslation.MOROI_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.MOROI_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence DeogenEv1 = new()
	{
		Name = PhasmaBusterTranslation.DEOGEN_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEOGEN_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence DeogenEv2 = new()
	{
		Name = PhasmaBusterTranslation.DEOGEN_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEOGEN_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence DeogenEv3 = new()
	{
		Name = PhasmaBusterTranslation.DEOGEN_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEOGEN_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence DeogenEv4 = new()
	{
		Name = PhasmaBusterTranslation.DEOGEN_EV4,
		Description = new()
		{
			Text = PhasmaBusterTranslation.DEOGEN_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ThayeEv1 = new()
	{
		Name = PhasmaBusterTranslation.THAYE_EV1,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THAYE_EV1_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ThayeEv2 = new()
	{
		Name = PhasmaBusterTranslation.THAYE_EV2,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THAYE_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Evidence ThayeEv3 = new()
	{
		Name = PhasmaBusterTranslation.THAYE_EV3,
		Description = new()
		{
			Text = PhasmaBusterTranslation.THAYE_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly Ghost Spirit = new()
	{
		Name = PhasmaBusterTranslation.SPIRIT,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					SpiritBox,
					Writing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					SpiritEv1
				]
			},
		},
	};

	private static readonly Ghost Wraith = new()
	{
		Name = PhasmaBusterTranslation.WRAITH,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					SpiritBox,
					Dots
				]
			},
			{
				EvidenceType.Behaviours,
				[
					WraithEv1
				]
			},
			{
				EvidenceType.Tells,
				[
					WraithEv2
				]
			}
		},
	};

	private static readonly Ghost Phantom = new()
	{
		Name = PhasmaBusterTranslation.PHANTOM,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					Ultraviolet,
					Dots
				]
			},
			{
				EvidenceType.Behaviours,
				[
					PhantomEv1
				]
			},
			{
				EvidenceType.Tells,
				[
					PhantomEv2,
					PhantomEv3
				]
			}
		},
	};

	private static readonly Ghost Poltergeist = new()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					Ultraviolet,
					Writing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					PoltergeistEv1,
					PoltergeistEv2,
					PoltergeistEv3
				]
			},
			{
				EvidenceType.Tells,
				[
					PoltergeistEv4
				]
			}
		},
	};

	private static readonly Ghost Banshee = new()
	{
		Name = PhasmaBusterTranslation.BANSHEE,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Ultraviolet,
					GhostOrbs,
					Dots
				]
			},
			{
				EvidenceType.Behaviours,
				[
					BansheeEv1,
					BansheeEv2,
					BansheeEv3,
					BansheeEv4
				]
			},
			{
				EvidenceType.Tells,
				[
					BansheeEv5,
					BansheeEv6
				]
			}
		},
	};

	private static readonly Ghost Jinn = new()
	{
		Name = PhasmaBusterTranslation.JINN,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Ultraviolet,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					JinnEv1
				]
			},
			{
				EvidenceType.Tells,
				[
					JinnEv2
				]
			}
		},
	};

	private static readonly Ghost Mare = new()
	{
		Name = PhasmaBusterTranslation.MARE,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					GhostOrbs,
					Writing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					MareEv1,
					MareEv2,
					MareEv3
				]
			},
			{
				EvidenceType.Tells,
				[
					MareEv4,
					MareEv5
				]
			}
		},
	};

	private static readonly Ghost Revenant = new()
	{
		Name = PhasmaBusterTranslation.REVENANT,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					GhostOrbs,
					Writing,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					RevenantEv1
				]
			},
		},
	};

	private static readonly Ghost Shadow = new()
	{
		Name = PhasmaBusterTranslation.SHADOW,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Writing,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					ShadowEv1,
					ShadowEv2,
					ShadowEv3,
					ShadowEv4,
					ShadowEv5,
					ShadowEv6
				]
			},
		},
	};

	private static readonly Ghost Demon = new()
	{
		Name = PhasmaBusterTranslation.DEMON,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Ultraviolet,
					Writing,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					DemonEv1,
					DemonEv2,
					DemonEv3
				]
			},
			{
				EvidenceType.Tells,
				[
					DemonEv4
				]
			}
		},
	};

	private static readonly Ghost Yurei = new()
	{
		Name = PhasmaBusterTranslation.YUREI,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					GhostOrbs,
					Freezing,
					Dots
				]
			},
			{
				EvidenceType.Behaviours,
				[
					YureiEv1
				]
			},
			{
				EvidenceType.Tells,
				[
					YureiEv2,
					YureiEv3,
					YureiEv4
				]
			}
		},
	};

	private static readonly Ghost Oni = new()
	{
		Name = PhasmaBusterTranslation.ONI,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Freezing,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					OniEv1,
					OniEv2
				]
			}
		},
	};

	private static readonly Ghost Yokai = new()
	{
		Name = PhasmaBusterTranslation.YOKAI,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					GhostOrbs,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					YokaiEv1,
					YokaiEv2,
					YokaiEv3
				]
			}
		},
	};

	private static readonly Ghost Hantu = new()
	{
		Name = PhasmaBusterTranslation.HANTU,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Ultraviolet,
					GhostOrbs,
					Freezing
				]
			},
			{
				EvidenceType.Tells,
				[
					HantuEv1,
					HantuEv2,
					HantuEv3,
					HantuEv4
				]
			}
		},
	};

	private static readonly Ghost Goryo = new()
	{
		Name = PhasmaBusterTranslation.GORYO,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Ultraviolet,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					GoryoEv1,
					GoryoEv2,
					GoryoEv3,
					GoryoEv4
				]
			}
		},
	};

	private static readonly Ghost Myling = new()
	{
		Name = PhasmaBusterTranslation.MYLING,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Ultraviolet,
					Writing
				]
			},
			{
				EvidenceType.Tells,
				[
					MylingEv1,
					MylingEv2
				]
			}
		},
	};

	private static readonly Ghost Onryo = new()
	{
		Name = PhasmaBusterTranslation.ONRYO,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Ultraviolet,
					Dots
				]
			},
			{
				EvidenceType.Behaviours,
				[
					OnryoEv3
				]
			},
			{
				EvidenceType.Tells,
				[
					OnryoEv1,
					OnryoEv2
				]
			}
		},
	};

	private static readonly Ghost TheTwins = new()
	{
		Name = PhasmaBusterTranslation.THE_TWINS,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					SpiritBox,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					TheTwinsEv6
				]
			},
			{
				EvidenceType.Tells,
				[
					TheTwinsEv1,
					TheTwinsEv2,
					TheTwinsEv3,
					TheTwinsEv4,
					TheTwinsEv5
				]
			}
		},
	};

	private static readonly Ghost Raiju = new()
	{
		Name = PhasmaBusterTranslation.RAIJU,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					GhostOrbs,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					RaijuEv1,
					RaijuEv2,
					RaijuEv3
				]
			}
		},
	};

	private static readonly Ghost Obake = new()
	{
		Name = PhasmaBusterTranslation.OBAKE,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					Emf5,
					Ultraviolet,
					GhostOrbs
				]
			},
			{
				EvidenceType.Behaviours,
				[
					ObakeEv4,
					ObakeEv5
				]
			},
			{
				EvidenceType.Tells,
				[
					ObakeEv1,
					ObakeEv2,
					ObakeEv3
				]
			}
		},
	};

	private static readonly Ghost Mimic = new()
	{
		Name = PhasmaBusterTranslation.MIMIC,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					Ultraviolet,
					Freezing
				]
			},
			{
				EvidenceType.Behaviours,
				[
					MimicEv3
				]
			},
			{
				EvidenceType.Tells,
				[
					MimicEv1,
					MimicEv2
				]
			}
		},
	};

	private static readonly Ghost Moroi = new()
	{
		Name = PhasmaBusterTranslation.MOROI,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					Writing,
					Freezing
				]
			},
			{
				EvidenceType.Tells,
				[
					MoroiEv1,
					MoroiEv2,
					MoroiEv3,
					MoroiEv4
				]
			}
		},
	};

	private static readonly Ghost Deogen = new()
	{
		Name = PhasmaBusterTranslation.DEOGEN,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					SpiritBox,
					Writing,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					DeogenEv1,
					DeogenEv2,
					DeogenEv3,
					DeogenEv4
				]
			}
		},
	};

	private static readonly Ghost Thaye = new()
	{
		Name = PhasmaBusterTranslation.THAYE,
		Evidences = new Dictionary<EvidenceType, List<Evidence>>()
		{
			{
				EvidenceType.Standard,
				[
					GhostOrbs,
					Writing,
					Dots
				]
			},
			{
				EvidenceType.Tells,
				[
					ThayeEv1,
					ThayeEv2,
					ThayeEv3
				]
			}
		},
	};

	public Model()
	{
		Evidences = new()
		{
			Emf5,
			Ultraviolet,
			SpiritBox,
			Writing,
			Freezing,
			Dots,
			GhostOrbs,
			SpiritEv1,
			WraithEv1,
			WraithEv2,
			PhantomEv1,
			PhantomEv2,
			PhantomEv3,
			PoltergeistEv1,
			PoltergeistEv2,
			PoltergeistEv3,
			PoltergeistEv4,
			BansheeEv1,
			BansheeEv2,
			BansheeEv3,
			BansheeEv4,
			BansheeEv5,
			BansheeEv6,
			JinnEv1,
			JinnEv2,
			MareEv1,
			MareEv2,
			MareEv3,
			MareEv4,
			MareEv5,
			RevenantEv1,
			ShadowEv1,
			ShadowEv2,
			ShadowEv3,
			ShadowEv4,
			ShadowEv5,
			ShadowEv6,
			DemonEv1,
			DemonEv2,
			DemonEv3,
			DemonEv4,
			YureiEv1,
			YureiEv2,
			YureiEv3,
			YureiEv4,
			OniEv1,
			OniEv2,
			YokaiEv1,
			YokaiEv2,
			YokaiEv3,
			HantuEv1,
			HantuEv2,
			HantuEv3,
			HantuEv4,
			GoryoEv1,
			GoryoEv2,
			GoryoEv3,
			GoryoEv4,
			MylingEv1,
			MylingEv2,
			OnryoEv1,
			OnryoEv2,
			OnryoEv3,
			TheTwinsEv1,
			TheTwinsEv2,
			TheTwinsEv3,
			TheTwinsEv4,
			TheTwinsEv5,
			TheTwinsEv6,
			RaijuEv1,
			RaijuEv2,
			RaijuEv3,
			ObakeEv1,
			ObakeEv2,
			ObakeEv3,
			ObakeEv4,
			ObakeEv5,
			MimicEv1,
			MimicEv2,
			MimicEv3,
			MoroiEv1,
			MoroiEv2,
			MoroiEv3,
			MoroiEv4,
			DeogenEv1,
			DeogenEv2,
			DeogenEv3,
			DeogenEv4,
			ThayeEv1,
			ThayeEv2,
			ThayeEv3,
		};
		

		Ghosts = new()
		{
			Spirit,
			Wraith,
			Phantom,
			Poltergeist,
			Banshee,
			Jinn,
			Mare,
			Revenant,
			Shadow,
			Demon,
			Yurei,
			Oni,
			Yokai,
			Hantu,
			Goryo,
			Myling,
			Onryo,
			TheTwins,
			Raiju,
			Obake,
			Mimic,
			Moroi,
			Deogen,
			Thaye,
		};
		foreach (var baseEvidence in Evidences)
		{
            FilterEvidences.Add(baseEvidence, EvidenceState.Idle);
        }
	}
}
