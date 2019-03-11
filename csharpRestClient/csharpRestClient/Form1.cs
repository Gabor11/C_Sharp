using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        private string route = "";
        public Form1()
        {
            InitializeComponent();
            chkID.Checked = true;
        }

        #region UI Event Handlers

        private void btnSend_Click(object sender, EventArgs e)
        {

            controlMain(tabEntity);
            //List<string> getParams = new List<string>();
            //if (tabEntity.SelectedTab == tabEntity.TabPages["tabGet"])
            //{
            //    getParams.Add(makeGETParameter("id", "1"));
            //    getParams.Add(makeGETParameter("book", "Boy of Fortune"));
            //    getParams.Add(makeGETParameter("page", "162"));

            //    MessageBox.Show("helló");

            //}


            //debugOutput(chainGETParameters(getParams));

        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                txtID.ReadOnly = false;
            }
            else
            {
                txtID.Clear();
                txtID.ReadOnly = true;
            }
        }

        #endregion 
        private void controlMain(TabControl tabEntity)
        {
            switch (tabEntity.SelectedTab.ToString())
            {
                case "TabPage: {Query}":
                    route = (chkID.Checked ? "/api/post/read_single.php" : "/api/post/read.php");
                    sendGet();
                    break;
                case "TabPage: {Create}":
                    route = "/api/post/create.php";
                    sendCreate();
                    break;
                case "TabPage: {Update}":
                    route = "/api/post/update.php";
                    sendUpdate();
                    break;
                case "TabPage: {Delete}":
                    route = "/api/post/delete.php";
                    sendDelete();
                    break;
                default:
                    MessageBox.Show("Nem nyert...");
                    break;

            }
        }

        private void sendGet()
        {
            string parameterString = (chkID.Checked ? "?" + makeGETParameter("id", txtID.Text) : string.Empty);
            string url = txtRestURI.Text + route;
            RestClient restClient = new RestClient(url, parameterString);

            string strResponse = string.Empty;

            try
            {
                strResponse = restClient.makeGetRequest();
                restOutput(strResponse, txtResponse);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void sendCreate()
        {
            string url = txtRestURI.Text + route;
            Dictionary<string, string> dataSet = new Dictionary<string, string>();

            dataSet.Add("username", txtName.Text);
            dataSet.Add("password", txtPassword.Text);
            dataSet.Add("title", txtTitle.Text);
            dataSet.Add("body", txtBody.Text);
            dataSet.Add("author", txtAuthor.Text);
            dataSet.Add("category_id", cmbCategoryID.Text);

            RestClient restClient = new RestClient(url, dataSet);

            string strResponse = string.Empty;

            try
            {
                strResponse = restClient.makePostRequest();
                MessageBox.Show (strResponse);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void sendUpdate()
        {
            string url = txtRestURI.Text + route;
            Dictionary<string, string> dataSet = new Dictionary<string, string>();

            dataSet.Add("username", txtName.Text);
            dataSet.Add("password", txtPassword.Text);
            dataSet.Add("id", txtID2Update.Text);
            dataSet.Add("title", txtTitle2Update.Text);
            dataSet.Add("body", txtBody2Update.Text);
            dataSet.Add("author", txtAuthor2Update.Text);
            dataSet.Add("category_id", cmbCategoryID2Update.Text);

            RestClient restClient = new RestClient(url, dataSet);

            string strResponse = string.Empty;

            try
            {
                strResponse = restClient.makePostRequest();
                MessageBox.Show(strResponse);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void sendDelete()
        {
            string url = txtRestURI.Text + route;
            Dictionary<string, string> dataSet = new Dictionary<string, string>();

            dataSet.Add("username", txtName.Text);
            dataSet.Add("password", txtPassword.Text);
            dataSet.Add("id", txtID2Delete.Text);

            RestClient restClient = new RestClient(url, dataSet);

            string strResponse = string.Empty;

            try
            {
                strResponse = restClient.makePostRequest();
                MessageBox.Show(strResponse);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void restOutput(string strDebugText, TextBox txtResponse)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write(e.Message, ToString() + Environment.NewLine);
            }
        }

        private string makeGETParameter(string parameterKey, string parameterValue)
        {
            return parameterKey.Replace(" ", "+") + "=" + parameterValue.Replace(" ","+");
        }

        private string chainGETParameters(List<string> GETParams)
        {
            string retVal = "?";
            foreach (string getParam in GETParams)
                retVal += getParam + "&";
            retVal = retVal.Remove(retVal.Length - 1);
            return retVal;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "name";
                txtName.ForeColor = Color.Silver;
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
