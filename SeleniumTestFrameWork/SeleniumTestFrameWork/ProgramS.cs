
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumtestFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestFrameWork
{
    public class ProgramS
    {
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://app.credijustra.lecom.com.br/admin/pages/cadastros/usuario/usuario.do?faces-redirect=true");
            ExecuteTest();
        }

        public static void ExecuteTest()
        {
            int Pessoa = 0;
            int Finaalizacao = 50;
            //login
            Task.Delay(2000).Wait();
            SeleniumSetMethods.EnterText("username", "adm", PropertyType.Name);
            SeleniumSetMethods.Click(@"/ html / body / div / div / div[1] / div[1] / div[2] / div / div / form / div[2] / div / div / span / button", PropertyType.Xpath);
            SeleniumSetMethods.EnterText("password", "N3xum@", PropertyType.Name);
            SeleniumSetMethods.Click(@"/ html / body / div / div / div[1] / div[1] / div[2] / div / div / form / div[2] / div / div / span / button", PropertyType.Xpath);
            PropertiesCollection.driver.Navigate().Refresh();//refresh
            SeleniumSetMethods.SelectDropDown("/html/body/form[2]/div/div/table/tbody/tr/td/div[2]/div/div/div[2]/select", "50", PropertyType.Xpath);
            do
            {
                if (Pessoa == Finaalizacao)
                {
                    SeleniumSetMethods.Click("/html/body/form[2]/div/div/table/tbody/tr/td/div[2]/div/div/div[2]/span[4]/span", PropertyType.Xpath);
                    Finaalizacao += 50;
                }
                string pessoa = "formPesquisa:acordionLista:usuarioLista:j_id_oh:j_id_oj:dataTableList:" + Pessoa.ToString() + ":j_id_oo"; SeleniumSetMethods.Click(pessoa, PropertyType.Id);
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tbody/tr/td/div/ul/li[2]/a", PropertyType.Xpath);//Permissão bpm
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tbody/tr/td/div/div/div[2]/table/tbody/tr[1]/td[2]/table/tbody/tr/td[1]/div/div[1]/input", PropertyType.Xpath);//Completo
                var checkbox = SeleniumGetMethods.GetCheckBox("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao", PropertyType.Name);//get checkbox
                if (checkbox == null)
                {
                    SeleniumSetMethods.Click("formCadastro:acordionCadastro:idUsuarioCad:tabViewPermissoes:j_id_by:selectPermissoesAlteracao", PropertyType.Name);// set checkbox
                }
                SeleniumSetMethods.Click("/html/body/form[1]/div/div/table/tfoot/tr/td/button[1]/span", PropertyType.Xpath);//enviar
                Pessoa++;
            } while (true);
        }
        public void CleanUp()
        {
        }
    }
}