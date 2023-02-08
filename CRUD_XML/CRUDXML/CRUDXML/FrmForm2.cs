using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace CRUDXML
{
    public partial class FrmForm2 : Form
    {
        private string FILE = "productos2.xml";
        //XDocument xmldoc;

        public FrmForm2()
        {
            InitializeComponent();
        }

        private void FrmForm2_Load(object sender, EventArgs e)
        {
            LeerArchivo();
            txt_cant_vend.Clear();
            txt_id.Clear();
            txt_nombre.Clear();
            txt_precio.Clear();
        }

        #region Private methods 

        /// <summary>
        /// Esta es un primer método para leer data de archivos XML
        /// </summary>
        /// <param name="myfilepath"></param>
        /// <returns></returns>
        private DataTable LeerDataXML(string myfilepath)
        {
            XmlTextReader xtr = new XmlTextReader(myfilepath);
            DataTable dt = new DataTable();
            while (xtr.Read())
            {
                Producto p = new Producto();

                if (xtr.NodeType == XmlNodeType.Text)
                {
                    MessageBox.Show(xtr.ReadContentAsString());
                }
                                
                //if (xtr.NodeType == XmlNodeType.Element)
                //{

                //    MessageBox.Show(xtr.Name);
                //    MessageBox.Show(xtr.ReadElementContentAsString());
                //}
            }
            return dt;
        }
        /// <summary>
        /// Esta es un segundo método para leer data de archivos XML usando DataTable
        /// </summary>
        /// <param name="myfilepath"></param>
        /// <returns></returns>
        private DataTable LeerDataXML2(string myfilepath)
        {
            try
            {
                DataSet dsConfig = new DataSet();
                DataTable dtConfig = new DataTable();
                dsConfig.ReadXml(myfilepath);
                dtConfig = dsConfig.Tables[0];

                if (dtConfig == null)
                {
                    return null;
                }
                if (dtConfig.Rows.Count <= 0)
                {
                    return null;
                }
                return dtConfig;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esta es un tercer método para leer data de archivos XML usando DataTable
        /// </summary>
        /// <param name="myfilepath"></param>
        /// <returns></returns>
        private List<Producto> LeerDataXML3(string myfilepath)
        {
            DataTable dt = new DataTable();
            List<Producto> products = new List<Producto>();
            try
            {
                XmlDocument doc  = new XmlDocument();
                doc.Load(myfilepath);
                Producto p = new Producto();
                for (int i = 0; i < doc.ChildNodes[0].ChildNodes.Count ; i++)
                {
                    foreach (XmlNode nd in doc.ChildNodes[0].ChildNodes[i])
                    {

                        foreach (XmlNode nd2 in nd.ChildNodes)
                        {
                            if (nd.Name.ToLower() == "id")
                            {
                                p.id = nd2.Value;
                            }
                            else if (nd.Name.ToLower() == "nombre")
                            {
                                p.nombre = nd2.Value;
                            }
                            else if (nd.Name.ToLower() == "precio")
                            {
                                p.precio = Convert.ToDouble(nd2.Value);
                            }
                            else if (nd.Name.ToLower() == "cantidad")
                            {
                                p.cantidad = Convert.ToInt16(nd2.Value);
                                products.Add(p);
                                p = new Producto();
                            }
                        }
                    }
                }

                foreach (var item in products)
                {
                    item.total = item.cantidad * item.precio;
                }
                
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void LeerArchivo()
        {
            try
            {
              dgvRows.DataSource = LeerDataXML3(FILE);
            }
            catch (Exception ex)
            {
              throw ex;
            }
        }
        public void metodo()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            txt_id.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerArchivo();
            metodo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //XElement emp = xmldoc.Descendants("producto").FirstOrDefault(p => p.Element("id").Value == txt_id.Text);
            //if (emp != null)
            //{
            //    emp.Remove();
            //    xmldoc.Save(FILE);
            //    LeerArchivo();
            //    metodo();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
