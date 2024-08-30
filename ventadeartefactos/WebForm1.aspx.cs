using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ventadeartefactos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cbarte.Items.Add("Selecciona");
                cbarte.Items.Add("filmadora");
                cbarte.Items.Add("licuadora");
                cbarte.Items.Add("radio");
                cbarte.Items.Add("televisor");
                cbarte.Items.Add("refrigera");


            }
        }

        protected void cbarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] pre = { 0, 600, 200, 150, 2100, 1600};
            int indice = cbarte.SelectedIndex;
            string cad = cbarte.Text;
            Image1.ImageUrl = "artefactos/" + cad + ".jpg";
            txtprecio.Text = pre[indice].ToString();

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes = int.Parse(rbnes.SelectedValue);
            double inte = 0, saldo, precio = double.Parse(txtprecio.Text);
      
            switch(mes)
            {
                case 6: inte = 0.10 * precio; break;
                case 12: inte = 0.20 * precio; break;
                case 18: inte = 0.30 * precio; break;
            }
            saldo = inte + precio;
            double cm = saldo / mes;
            txtinte.Text = inte.ToString();
            txtsaldo.Text = saldo.ToString();
            txtcuota.Text = cm.ToString();
                
               
        }
    }
}