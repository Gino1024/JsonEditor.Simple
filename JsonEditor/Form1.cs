using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonEditor
{
    public partial class JsonEditor : Form
    {
        public JsonEditor()
        {
            InitializeComponent();
        }

        private void JsonEditor_Load(object sender, EventArgs e)
        {
        }

        private void ConvertToTreeBtn_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            string jsonTxt = JsonTxt.Text;

            if (string.IsNullOrEmpty(jsonTxt))
            {
                MessageBox.Show("不得為空","err");
                return;
            }

            if (!canJsonParse(jsonTxt))
            {
                MessageBox.Show("格式有誤","err");
                return;
            }
            var root = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(jsonTxt);
            RenderTreeView(treeView1.Nodes, root);

            JObject json = JObject.Parse(jsonTxt);
            JsonTxt.Text = json.ToString();
        }

        private bool canJsonParse(string JsonTxt)
        {
            bool result = false;
            try
            {
                var root = JObject.Parse(JsonTxt);
                result = (root != null) ? true : false;
            }
            catch
            {

            }
            return result;
        }

        private void RenderTreeView(TreeNodeCollection nodes, JObject datas)
        {
            try
            {
                int layer = 0;
                foreach (JProperty datasProp in datas.Properties())
                {
                    bool isDeep = canJsonParse(datasProp.Value.ToString());

                    if (isDeep)
                    {
                        nodes.Add($"{datasProp.Name}");
                        JObject subDatas = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(datasProp.Value.ToString());
                        RenderTreeView(nodes[layer].Nodes,subDatas);
                    }
                    else
                    {
                        nodes.Add(string.Format("{0} : {1}", datasProp.Name, RenderPropValue(datasProp.Value)));
                    }
                    layer++;
                }
            }
            catch
            {
                return;
            }
        }

        private string RenderPropValue(JToken prop)
        {
            string result = string.Empty;
            switch (prop.Type.ToString())
            {
                case "String":
                    result = $"\"{prop}\"";
                    break;
                default:
                    result = string.IsNullOrEmpty(prop.ToString()) ? "null" : prop.ToString();
                    break;
            }
            return result;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
