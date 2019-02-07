using MChooser.Constants;
using MChooser.Models;
using MChooser.XMLControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChooser.UI
{
    public partial class MechCountForm : Form
    {
        private Action SwitchSelect;
        private Action SwitchToAddMech;
        private MechClasses[] AllClasses = new MechClasses[] { MechClasses.ASSAULT, MechClasses.HEAVY, MechClasses.LIGHT, MechClasses.MEDIUM };
        private Factions[] AllFactions = new Factions[] { Factions.CLAN, Factions.INNER_SPHERE };
        private List<MechModel> choosableModels;

        public MechCountForm(Action switchToSelect, Action switchToAddMech)
        {
            this.SwitchSelect = switchToSelect;
            this.SwitchToAddMech = switchToAddMech;
            choosableModels = XMLRetriever.GetMechModels(AllClasses, AllFactions);
            InitializeComponent();
            FillOutForm();
            // Inner Sphere light mechs
            IS20TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, LightMechWeightIncrements.TWENTY.ToString()); };
            IS25TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, LightMechWeightIncrements.TWENTY_FIVE.ToString()); };
            IS30TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, LightMechWeightIncrements.THIRTY.ToString()); };
            IS35TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, LightMechWeightIncrements.THIRTY_FIVE.ToString()); };

            // Clan light mechs
            clan20TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, LightMechWeightIncrements.TWENTY.ToString()); };
            clan25TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, LightMechWeightIncrements.TWENTY_FIVE.ToString()); };
            clan30TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, LightMechWeightIncrements.THIRTY.ToString()); };
            clan35TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, LightMechWeightIncrements.THIRTY_FIVE.ToString()); };

            // Inner Sphere medium mechs
            IS40TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, MediumMechWeightIncrements.FORTY.ToString()); };
            IS45TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, MediumMechWeightIncrements.FORTY_FIVE.ToString()); };
            IS50TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, MediumMechWeightIncrements.FIFTY.ToString()); };
            IS55TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, MediumMechWeightIncrements.FIFTY_FIVE.ToString()); };

            // Clan medium mechs
            clan40TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, MediumMechWeightIncrements.FORTY.ToString()); };
            clan45TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, MediumMechWeightIncrements.FORTY_FIVE.ToString()); };
            clan50TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, MediumMechWeightIncrements.FIFTY.ToString()); };
            clan55TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, MediumMechWeightIncrements.FIFTY_FIVE.ToString()); };

            // Inner Sphere heavy mechs
            IS60TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, HeavyMechWeightIncrements.SIXTY.ToString()); };
            IS65TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, HeavyMechWeightIncrements.SIXTY_FIVE.ToString()); };
            IS70TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, HeavyMechWeightIncrements.SEVENTY.ToString()); };
            IS75TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, HeavyMechWeightIncrements.SEVENTY_FIVE.ToString()); };

            // Clan heavy mechs
            clan60TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, HeavyMechWeightIncrements.SIXTY.ToString()); };
            clan65TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, HeavyMechWeightIncrements.SIXTY_FIVE.ToString()); };
            clan70TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, HeavyMechWeightIncrements.SEVENTY.ToString()); };
            clan75TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, HeavyMechWeightIncrements.SEVENTY_FIVE.ToString()); };

            // Inner Sphere assault mechs
            IS80TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, AssaultMechWeightIncrements.EIGHTY.ToString()); };
            IS85TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, AssaultMechWeightIncrements.EIGHTY_FIVE.ToString()); };
            IS90TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, AssaultMechWeightIncrements.NINETY.ToString()); };
            IS95TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, AssaultMechWeightIncrements.NINETY_FIVE.ToString()); };
            IS100TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.INNER_SPHERE, AssaultMechWeightIncrements.HUNDRED.ToString()); };

            // Clan assault mechs
            clan80TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, AssaultMechWeightIncrements.EIGHTY.ToString()); };
            clan85TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, AssaultMechWeightIncrements.EIGHTY_FIVE.ToString()); };
            clan90TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, AssaultMechWeightIncrements.NINETY.ToString()); };
            clan95TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, AssaultMechWeightIncrements.NINETY_FIVE.ToString()); };
            clan100TonMoreButton.Click += delegate (object sender, EventArgs e) { OpenMoreWindow(sender, e, Factions.CLAN, AssaultMechWeightIncrements.HUNDRED.ToString()); };
        }

        private void FillOutForm()
        {
            // Split into separate lists by weight class
            List<MechModel> lightMechs = choosableModels.Where(e => e.MechClass == MechClasses.LIGHT).ToList();
            List<MechModel> mediumMechs = choosableModels.Where(e => e.MechClass == MechClasses.MEDIUM).ToList();
            List<MechModel> heavyMechs = choosableModels.Where(e => e.MechClass == MechClasses.HEAVY).ToList();
            List<MechModel> assaultMechs = choosableModels.Where(e => e.MechClass == MechClasses.ASSAULT).ToList();

            FillOutLightMechs(lightMechs);
            FillOutMediumMechs(mediumMechs);
            FillOutHeavyMechs(heavyMechs);
            FillOutAssaultMechs(assaultMechs);
        }

        private void FillOutLightMechs(List<MechModel> lightMechs)
        {
            // Fill in 20 ton mechs
            IS20Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.TWENTY.ToString()))
                            .ToList().Count.ToString();
            clan20Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.TWENTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 25 ton mechs
            IS25Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.TWENTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan25Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.TWENTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            // Fill in 30 ton mechs
            IS30Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.THIRTY.ToString()))
                            .ToList().Count.ToString();
            clan30Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.THIRTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 35 ton mechs
            IS35Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.THIRTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan35Ton.Text = lightMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(LightMechWeightIncrements.THIRTY_FIVE.ToString()))
                            .ToList().Count.ToString();
        }

        private void FillOutMediumMechs(List<MechModel> mediumMechs)
        {
            // Fill in 40 ton mechs
            IS40Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FORTY.ToString()))
                            .ToList().Count.ToString();
            clan40Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FORTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 45 ton mechs
            IS45Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FORTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan45Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FORTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            // Fill in 50 ton mechs
            IS50Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FIFTY.ToString()))
                            .ToList().Count.ToString();
            clan50Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FIFTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 55 ton mechs
            IS55Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FIFTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan55Ton.Text = mediumMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(MediumMechWeightIncrements.FIFTY_FIVE.ToString()))
                            .ToList().Count.ToString();
        }

        private void FillOutHeavyMechs(List<MechModel> heavyMechs)
        {
            // Fill in 60 ton mechs
            IS60Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SIXTY.ToString()))
                            .ToList().Count.ToString();
            clan60Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SIXTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 65 ton mechs
            IS65Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SIXTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan65Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SIXTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            // Fill in 70 ton mechs
            IS70Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SEVENTY.ToString()))
                            .ToList().Count.ToString();
            clan70Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SEVENTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 75 ton mechs
            IS75Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SEVENTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan75Ton.Text = heavyMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(HeavyMechWeightIncrements.SEVENTY_FIVE.ToString()))
                            .ToList().Count.ToString();
        }

        private void FillOutAssaultMechs(List<MechModel> assaultMechs)
        {
            // Fill in 80 ton mechs
            IS80Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.EIGHTY.ToString()))
                            .ToList().Count.ToString();
            clan80Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.EIGHTY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 85 ton mechs
            IS85Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.EIGHTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan85Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.EIGHTY_FIVE.ToString()))
                            .ToList().Count.ToString();
            // Fill in 90 ton mechs
            IS90Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.NINETY.ToString()))
                            .ToList().Count.ToString();
            clan90Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.NINETY.ToString()))
                            .ToList().Count.ToString();
            // Fill in 95 ton mechs
            IS95Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.NINETY_FIVE.ToString()))
                            .ToList().Count.ToString();
            clan95Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.NINETY_FIVE.ToString()))
                            .ToList().Count.ToString();
            // Fill in 100 ton mechs
            IS100Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.INNER_SPHERE
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.HUNDRED.ToString()))
                            .ToList().Count.ToString();
            clan100Ton.Text = assaultMechs.Where(e => e.MechFaction == Factions.CLAN
                            && e.GetMechWeight().Equals(AssaultMechWeightIncrements.HUNDRED.ToString()))
                            .ToList().Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchSelect();
        }

        private void addMechButton_Click(object sender, EventArgs e)
        {
            SwitchToAddMech();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenMoreWindow(object sender, EventArgs e, Factions faction, string weightClass)
        {
            List<MechModel> details = GetMoreInformationMechs(faction, weightClass);
            MoreInformationWindow popUp = new MoreInformationWindow(details, String.Format("Your mechs weighing {0} tons", weightClass.Replace("_", " ")));
            popUp.ShowDialog();
        }

        private List<MechModel> GetMoreInformationMechs(Factions faction, string weight)
        {
            return choosableModels.Where(m => m.MechFaction == faction && m.GetMechWeight().Equals(weight))
                .OrderBy(m => m.MechModelName)
                .ToList();
        }
    }
}
