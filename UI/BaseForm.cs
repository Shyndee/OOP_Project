using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BaseForm : Form
    {
        //every button calls a virtual method, which will be overriden in each individual form
        public BaseForm()
        {
            InitializeComponent();
        }//end ctor
        private void buttonBackHome2_Click(object sender, EventArgs e)
        {
            //calls virtual method
            BackToHome();
        }//end backtohome
        protected virtual void BackToHome()
        {
           // buttonUpdate.Visible = false;
           // ButtonAdd.Visible = false;
           // ButtonRetreive.Visible = false;
           // DeletePr.Visible = false;
        }//end newClick
        private void Create_Click(object sender, EventArgs e)
        {
            //ButtonAdd.Visible = true;
            NewClick();

        }//end create click
        protected virtual void NewClick()
        {

        }//end newClick
        private void Reatrieve_Click(object sender, EventArgs e)
        {
          //  ButtonRetreive.Visible = true;
            newRetrieve();
        }//end retrieve click
        protected virtual void newRetrieve()
        {

        }//end new retrieve 
        private void Update_Click(object sender, EventArgs e)
        {
            //buttonUpdate.Visible = true;
            NewUpdate();
        }//end method
        protected virtual void NewUpdate()
        {

        }//end method
        private void Delete_Click(object sender, EventArgs e)
        {
            //DeletePr.Visible = true;
            NewDelete();
        }//end method
        protected virtual void NewDelete()
        {

        }//end method
        private void listBoxRA_SelectedIndexChanged(object sender, EventArgs e)
        {
            New_ListBox();
        }//end method
        protected virtual void New_ListBox()
        {

        }//end method
        private void ReatrieveAll_Click(object sender, EventArgs e)
        {
            newRetrieveAll();
        }//end retrieve all
        protected virtual void newRetrieveAll()
        {

        }//end new retrieve all
        private void BackHomeBase_Click(object sender, EventArgs e)
        {
            BackHomeMethod();
        }
        protected virtual void BackHomeMethod() 
        { }
        private void BackToMain_Click(object sender, EventArgs e)
        {
            BackToMainButton();
        }
        protected virtual void BackToMainButton()
        {

        }
        private void BackHome_Click(object sender, EventArgs e)
        {
            BackHomeMethod();
        }
    }//end class
}//end namespace
