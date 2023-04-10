using OpenQA.Selenium.Chrome;
using SeleniumtestFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTestFrameWork
{
    public partial class frmSelenium : Form
    {
        string site;
        public bool Homologacao = false; public bool Producao = false;
        public frmSelenium()
        {
            InitializeComponent();
        }

        private void btnLigarRPA_Click(object sender, EventArgs e)
        {
            if (Producao == true && lblMostrar.Text != "" || Homologacao == true && lblMostrar.Text != "")
            {
                Inicializar();
            }
            else
            {
                MessageBox.Show("Link não apresentado tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Inicializar()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl(site);
        }

        public void ExecuteTest()
        {
            int Pessoa = 0;
            int Finaalizacao = 50;
            //login
            Task.Delay(2000).Wait();
            if (Producao == true)
            {
                SeleniumSetMethods.EnterText("username", "adm", PropertyType.Name);
                SeleniumSetMethods.Click(@"/html/body/div/div/div[1]/div[1]/div[2]/div/div/form/div[1]/div[2]/div/span/div/span/input", PropertyType.Xpath);
                SeleniumSetMethods.EnterText("password", "N3xum@", PropertyType.Name);
                SeleniumSetMethods.Click(@"/ html / body / div / div / div[1] / div[1] / div[2] / div / div / form / div[2] / div / div / span / button", PropertyType.Xpath);
            }
            if (Homologacao == true)
            {
                SeleniumSetMethods.EnterText("username", "adm", PropertyType.Name);
                SeleniumSetMethods.Click(@"/html/body/div/div/div[1]/div[1]/div[2]/div/div/form/div[1]/div[2]/div/span/div/span/input", PropertyType.Xpath);
                SeleniumSetMethods.EnterText("password", "lecom", PropertyType.Name);
                SeleniumSetMethods.Click(@"/ html / body / div / div / div[1] / div[1] / div[2] / div / div / form / div[2] / div / div / span / button", PropertyType.Xpath);
            }
            PropertiesCollection.driver.Navigate().Refresh();//refresh
            SeleniumSetMethods.SelectDropDown("/html/body/form[2]/div/div/table/tbody/tr/td/div[2]/div/div/div[2]/select", "50", PropertyType.Xpath,true);
            do
            {
                if (Pessoa == Finaalizacao)
                {
                    SeleniumSetMethods.Click("/html/body/form[2]/div/div/table/tbody/tr/td/div[2]/div/div/div[2]/span[4]/span", PropertyType.Xpath, true);
                    Finaalizacao += 50;
                }
                string pessoa = "formPesquisa:acordionLista:usuarioLista:j_id_oh:j_id_oj:dataTableList:" + Pessoa.ToString() + ":j_id_oo"; SeleniumSetMethods.Click(pessoa, PropertyType.Id, true);
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tbody/tr/td/div/ul/li[2]/a", PropertyType.Xpath);//Permissão bpm
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tbody/tr/td/div/div/div[2]/table/tbody/tr[1]/td[2]/table/tbody/tr/td[1]/div/div[1]/input", PropertyType.Xpath);//Completo
                var checkbox = SeleniumGetMethods.GetCheckBox("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao", PropertyType.Name);//get checkbox
                if (checkbox == null)
                {
                    SeleniumSetMethods.Click("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao", PropertyType.Name);// set checkbox
                }
                if (Homologacao == true)
                {
                    var checkbox2 = SeleniumGetMethods.GetCheckBox("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao", PropertyType.Name);//get checkbox
                    if (checkbox2 == null)
                    {
                        SeleniumSetMethods.Click("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao:1", PropertyType.Name);// set checkbox
                    }
                }
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tfoot/tr/td/button[1]/span", PropertyType.Xpath, true);//enviar
                Pessoa++;
            }while (true);
        }
        public void Identificar()
        {
            if (Producao == true)
            {
                site = "https://app." + lblApresentação.Text.ToLower() + ".lecom.com.br/admin/pages/cadastros/usuario/usuario.do?faces-redirect=true";
                lblMostrar.Text = site;
            }
            if (Homologacao == true)
            {
                site = "https://app-hom." + lblApresentação.Text.ToLower() + ".lecom.com.br/admin/pages/cadastros/usuario/usuario.do?faces-redirect=true";
                lblMostrar.Text = site;
            }
        }
        private void radCrediconsumo_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Crediconsumo";
            limpar();
        }

        private void radCentrosul_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Centrosul";
            limpar();
        }

        private void radCredijustra_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credijustra";
            limpar();
        }

        private void radCrediembrapa_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Crediembrapa";
            limpar();
        }

        private void radCredirural_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credirural";
            limpar();
        }

        private void radCredibrasilia_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credibrasilia";
            limpar();
        }

        private void radCrediguaçu_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Crediguacu";
            limpar();
        }

        private void radCredicaf_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credicaf";
            limpar();
        }

        private void radCoo_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Coocafe";
            limpar();
        }

        private void radCredimata_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credimata";
            limpar();
        }

        private void radCredifor_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Credifor";
            limpar();
        }

        private void radDivicred_CheckedChanged(object sender, EventArgs e)
        {
            lblApresentação.Text = "Divicred";
            limpar();
        }

        private void btnHom_Click(object sender, EventArgs e)
        {
            Producao = false; Homologacao = true;
            btnHom.BackColor = Color.Green; btnPro.BackColor = Color.White;
            Identificar();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Producao = true; Homologacao = false;
            btnPro.BackColor = Color.Green; btnHom.BackColor = Color.White;
            Identificar();
        }
        private void limpar()
        {
            Producao = false; Homologacao = false;
            btnPro.BackColor = Color.White; btnHom.BackColor = Color.White;
            lblMostrar.Text = "";
        }

        private void frmSelenium_Load(object sender, EventArgs e)
        {

        }
    }
}
