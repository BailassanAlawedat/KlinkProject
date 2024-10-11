using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class ctrMiratbeiterKarte : UserControl
    {
        clsMitarbeiterDaten _mitarbeiterDaten;
        public ctrMiratbeiterKarte()
        {
            InitializeComponent();
        }
        private void ctrMiratbeiterKarte_Load(object sender, EventArgs e)
        {

        }

        public void LoadMitarbeiterDatenByMitarbeiterID(int MitarbeiterId)
        {
            _mitarbeiterDaten = clsMitarbeiterDaten.Find(MitarbeiterId);

            if (_mitarbeiterDaten != null)
            {
                lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
                txtAbteilung.Text = _mitarbeiterDaten.Abteilung;
                txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
        }

        public void LoadReinigungsPersonalDatenByMitarbeiterID(int MitarbeiterID)
        {
            clsReinigungsPersonalDaten _ReinigungsPersonalmitarbeiterDaten = clsReinigungsPersonalDaten.FindByMitarbeiterID(MitarbeiterID);

            if (_ReinigungsPersonalmitarbeiterDaten != null)
            {
                lblPersonalID.Text = _ReinigungsPersonalmitarbeiterDaten.PersonalID.ToString();
                txtImBereich.Text = _ReinigungsPersonalmitarbeiterDaten.Bereichname;

                _mitarbeiterDaten = clsMitarbeiterDaten.Find(_ReinigungsPersonalmitarbeiterDaten.MitabeiterID); ;

                if (_mitarbeiterDaten != null)
                {
                    lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                    lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                    lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                    txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
                    txtAbteilung.Text = _mitarbeiterDaten.Abteilung;
                    txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                    txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                    txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                    txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
                }
                else
                    MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser PersonalID wurde gefunden", "Fehlermeldung");
        }

        public void LoaKüchenPersonalDatenByMitarbeiterID(int MitarbeiterId)
        {
            clsKüchenPersonalDaten _KüchenPersonalmitarbeiterDaten = clsKüchenPersonalDaten.FindByMitarbeiterID(MitarbeiterId);

            if (_KüchenPersonalmitarbeiterDaten != null)
            {
                lblPersonalID.Text = _KüchenPersonalmitarbeiterDaten.PersonalID.ToString();
                txtImBereich.Text = _KüchenPersonalmitarbeiterDaten.Bereichname;

                _mitarbeiterDaten = clsMitarbeiterDaten.Find(_KüchenPersonalmitarbeiterDaten.MitabeiterID); ;

                if (_mitarbeiterDaten != null)
                {
                    lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                    lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                    lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                    txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
                    txtAbteilung.Text = _mitarbeiterDaten.Abteilung;
                    txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                    txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                    txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                    txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
                }
                else
                    MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser PersonalID wurde gefunden", "Fehlermeldung");
        }

        public void LoadTransportdiensteByMitarbeiterID(int MitarbeiterId)
        {
            clsTransportdienstDaten _TransportdienstmitarbeiterDaten = clsTransportdienstDaten.FindByMitarbeiterID(MitarbeiterId);

            if (_TransportdienstmitarbeiterDaten != null)
            {
                lblPersonalID.Text = _TransportdienstmitarbeiterDaten.PersonalID.ToString();
                txtImBereich.Text = _TransportdienstmitarbeiterDaten.Bereichname;

                _mitarbeiterDaten = clsMitarbeiterDaten.Find(_TransportdienstmitarbeiterDaten.MitabeiterID); ;

                if (_mitarbeiterDaten != null)
                {
                    lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                    lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                    lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                    txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
                    txtAbteilung.Text = _mitarbeiterDaten.Abteilung;
                    txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                    txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                    txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                    txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
                }
                else
                    MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser PersonalID wurde gefunden", "Fehlermeldung");
        }

        public void LoadSicherheitsdiensteByMitarbeiterID(int MitarbeiterId)
        {
            clsSicherheitsdienstDaten _SicherheitsdienstmitarbeiterDaten = clsSicherheitsdienstDaten.FindByMitarbeiterID(MitarbeiterId);

            if (_SicherheitsdienstmitarbeiterDaten != null)
            {
                lblPersonalID.Text = _SicherheitsdienstmitarbeiterDaten.PersonalID.ToString();
                txtImBereich.Text = _SicherheitsdienstmitarbeiterDaten.Bereichname;

                _mitarbeiterDaten = clsMitarbeiterDaten.Find(_SicherheitsdienstmitarbeiterDaten.MitabeiterID); ;

                if (_mitarbeiterDaten != null)
                {
                    lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                    lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                    lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                    txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
                    txtAbteilung.Text = _mitarbeiterDaten.Abteilung;
                    txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                    txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                    txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                    txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
                }
                else
                    MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser PersonalID wurde gefunden", "Fehlermeldung");
        }
    }
}
