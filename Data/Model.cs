using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Data.Evidences;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data;

public class Model
{
	public readonly Dictionary<BaseEvidence, EvidenceState> FilterEvidences = new();
	public readonly List<BaseEvidence> Evidences;
	public readonly List<Ghost> Ghosts;

	#region StandardEvidence

	private static readonly StandardEvidence Emf5 = new ()
	{
		Name = PhasmaBusterTranslation.EMF5,
		Sequence = 0,
		Category = EvidenceType.Standart,
		Color = Color.Red,
		IconName = "radar"
	};

	private static readonly StandardEvidence Ultraviolet = new ()
	{
		Name = PhasmaBusterTranslation.ULTRAVIOLET,
		Sequence = 1,
		Category = EvidenceType.Standart,
		Color = Color.Khaki,
		IconName = "fingerprint"
	};

	private static readonly StandardEvidence SpiritBox = new ()
	{
		Name = PhasmaBusterTranslation.SPIRIT_BOX,
		Sequence = 2,
		Category = EvidenceType.Standart,
		Color = Color.Orange,
		IconName = "radio"
	};

	private static readonly StandardEvidence Writing = new ()
	{
		Name = PhasmaBusterTranslation.WRITING,
		Sequence = 3,
		Category = EvidenceType.Standart,
		Color = Color.RoyalBlue,
		IconName = "note_alt"
	};

	private static readonly StandardEvidence Freezing = new ()
	{
		Name = PhasmaBusterTranslation.FREEZING,
		Sequence = 4,
		Category = EvidenceType.Standart,
		Color = Color.SkyBlue,
		IconName = "ac_unit"
	};

	private static readonly StandardEvidence Dots = new ()
	{
		Name = PhasmaBusterTranslation.DOTS,
		Sequence = 5,
		Category = EvidenceType.Standart,
		Color = Color.Green,
		IconName = "blur_on"
	};

	private static readonly StandardEvidence GhostOrbs = new ()
	{
		Name = PhasmaBusterTranslation.GHOST_ORBS,
		Sequence = 6,
		Category = EvidenceType.Standart,
		Color = Color.Khaki,
		IconName = "auto_awesome"
	};

	#endregion

	#region HiddenEvidences

	private static readonly BehaviourEvidence BansheeEv1 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV1_D,
			EvidenceDescriptionType = EvidenceDescriptionType.Audio,
			FilePath = "banshee_scream.mp3",
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence BansheeEv2 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence BansheeEv3 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence BansheeEv4 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV4,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV4_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence BansheeEv5 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV5,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV5_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly TellsEvidence BansheeEv6 = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE_EV6,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.BANSHEE_EV6_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly BehaviourEvidence PhantomEv1 = new ()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence PhantomEv2 = new ()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly TellsEvidence PhantomEv3 = new ()
	{
		Name = PhasmaBusterTranslation.PHANTOM_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.PHANTOM_EV3_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly BehaviourEvidence PoltergeistEv1 = new ()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence PoltergeistEv2 = new ()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence PoltergeistEv3 = new ()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence PoltergeistEv4 = new ()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST_EV4,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.POLTERGEIST_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly BehaviourEvidence JinnEv1 = new ()
	{
		Name = PhasmaBusterTranslation.JINN_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.JINN_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence JinnEv2 = new ()
	{
		Name = PhasmaBusterTranslation.JINN_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.JINN_EV2_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly BehaviourEvidence MareEv1 = new ()
	{
		Name = PhasmaBusterTranslation.MARE_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.MARE_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence MareEv2 = new ()
	{
		Name = PhasmaBusterTranslation.MARE_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.MARE_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence MareEv3 = new ()
	{
		Name = PhasmaBusterTranslation.MARE_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.MARE_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence MareEv4 = new ()
	{
		Name = PhasmaBusterTranslation.MARE_EV4,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.MARE_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly TellsEvidence MareEv5 = new ()
	{
		Name = PhasmaBusterTranslation.MARE_EV5,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.MARE_EV5_D,
		},
		Category = EvidenceType.Tells
	};

	private static readonly BehaviourEvidence RevenantEv1 = new ()
	{
		Name = PhasmaBusterTranslation.REVENANT_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.REVENANT_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv1 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv2 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv3 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv4 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV4,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV4_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv5 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV5,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV5_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence ShadowEv6 = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW_EV6,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.SHADOW_EV6_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence DemonEv1 = new ()
	{
		Name = PhasmaBusterTranslation.DEMON_EV1,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.DEMON_EV1_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence DemonEv2 = new ()
	{
		Name = PhasmaBusterTranslation.DEMON_EV2,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.DEMON_EV2_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly BehaviourEvidence DemonEv3 = new ()
	{
		Name = PhasmaBusterTranslation.DEMON_EV3,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.DEMON_EV3_D,
		},
		Category = EvidenceType.Behaviours
	};

	private static readonly TellsEvidence DemonEv4 = new ()
	{
		Name = PhasmaBusterTranslation.DEMON_EV4,
		Description = new ()
		{
			Text = PhasmaBusterTranslation.DEMON_EV4_D,
		},
		Category = EvidenceType.Tells
	};

	#endregion

	#region Ghosts

	private static readonly Ghost Phantom = new ()
	{
		Name = PhasmaBusterTranslation.PHANTOM,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					SpiritBox,
					Ultraviolet,
					Dots
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					PhantomEv2,
					PhantomEv3,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					PhantomEv1,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 50.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	private static readonly Ghost Poltergeist = new ()
	{
		Name = PhasmaBusterTranslation.POLTERGEIST,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					SpiritBox,
					Ultraviolet,
					Writing
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					PoltergeistEv4,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					PoltergeistEv1,
					PoltergeistEv2,
					PoltergeistEv3,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 50.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	private static readonly Ghost Banshee = new ()
	{
		Name = PhasmaBusterTranslation.BANSHEE,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					Ultraviolet,
					GhostOrbs,
					Dots
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					BansheeEv5,
					BansheeEv6,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					BansheeEv1,
					BansheeEv2,
					BansheeEv3,
					BansheeEv4,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 50.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	private static readonly Ghost Jinn = new ()
	{
		Name = PhasmaBusterTranslation.JINN,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					Emf5,
					Ultraviolet,
					Freezing
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					JinnEv2,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					JinnEv1,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 50.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				},
				new()
				{
					Sequence = 1,
					Value = 2.5m
				}
			}
		}
	};

	private static readonly Ghost Mare = new ()
	{
		Name = PhasmaBusterTranslation.MARE,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					SpiritBox,
					GhostOrbs,
					Writing
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					MareEv4,
					MareEv5,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					MareEv1,
					MareEv2,
					MareEv3,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 40.0m,
				},
				new()
				{
					Sequence = 1,
					Value = 60.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	private static readonly Ghost Revenant = new ()
	{
		Name = PhasmaBusterTranslation.REVENANT,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					GhostOrbs,
					Writing,
					Freezing
				}
			},
            {
                EvidenceType.Behaviours,
                new ()
                {
					RevenantEv1,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 50.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.0m
				},
				new()
				{
					Sequence = 1,
					Value = 3.0m
				}
			}
		}
	};

	private static readonly Ghost Shadow = new ()
	{
		Name = PhasmaBusterTranslation.SHADOW,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					Emf5,
					Writing,
					Freezing
				}
			},
            {
                EvidenceType.Behaviours,
                new ()
                {
					ShadowEv1,
					ShadowEv2,
					ShadowEv3,
					ShadowEv4,
					ShadowEv5,
					ShadowEv6,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 35.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	private static readonly Ghost Demon = new ()
	{
		Name = PhasmaBusterTranslation.DEMON,
		Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
		{
			{
				EvidenceType.Standart,
				new ()
				{
					Ultraviolet,
					Writing,
					Freezing
				}
			},
            {
                EvidenceType.Tells,
                new ()
                {
					DemonEv4,

                }
            },
            {
                EvidenceType.Behaviours,
                new ()
                {
					DemonEv1,
					DemonEv2,
					DemonEv3,

                }
            }
		},
		SanityEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SANITY,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 70.0m,
				}
			}
		},
		SpeedEvidence = new ()
		{
			Name = PhasmaBusterTranslation.SPEED,
			Values = new()
			{
				new()
				{
					Sequence = 0,
					Value = 1.7m
				}
			}
		}
	};

	#endregion

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
			PhantomEv2,
			PhantomEv3,
			PhantomEv1,
			PoltergeistEv4,
			PoltergeistEv1,
			PoltergeistEv2,
			PoltergeistEv3,
			BansheeEv5,
			BansheeEv6,
			BansheeEv1,
			BansheeEv2,
			BansheeEv3,
			BansheeEv4,
			JinnEv2,
			JinnEv1,
			MareEv4,
			MareEv5,
			MareEv1,
			MareEv2,
			MareEv3,
			RevenantEv1,
			ShadowEv1,
			ShadowEv2,
			ShadowEv3,
			ShadowEv4,
			ShadowEv5,
			ShadowEv6,
			DemonEv4,
			DemonEv1,
			DemonEv2,
			DemonEv3,
		};
		Ghosts = new()
		{
			Phantom,
			Poltergeist,
			Banshee,
			Jinn,
			Mare,
			Revenant,
			Shadow,
			Demon,
		};
		foreach (var baseEvidence in Evidences)
		{
			FilterEvidences.Add(baseEvidence, EvidenceState.Idle);
		}
	}
}
