using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Order_System
{
public partial class Form1 : Form
{
// Global variable declaration:- Here Global variables are declared  
String ServerName;
int MPizza, PepPizza, HamPizza;
decimal AvgTransaction, TableOrderReceipts;
//List is used to store the variable value in order to calculate the Company Summary Details.   
List<decimal> TotalCompanyReceipts = new List<decimal>();
List<decimal> TotalCompanyTransctns = new List<decimal>();
List<int> No_of_Pizzas = new List<int>();
        
        
public Form1()
{
InitializeComponent();
}

private void label2_Click(object sender, EventArgs e)
{
}

private void groupBox2_Enter(object sender, EventArgs e)
{

}
/* This event handler load the form with focusing on ServerName text box. 
* PanelOne is made visible. Which contains ServerName Label, Table Number Label and Start Button.
* Rest all Labels, Panel and Buttons made invisible.
*/
private void Form1_Load(object sender, EventArgs e)
{
S_Name.Focus();
S_Name.SelectAll();
GroupBoxPizzaMenu.Visible = false;
PanelOne.Visible = true;                                    
// it makes PanlOne visible.
PanelTwo.Visible = false;
GroupBox_CompanyDetails.Visible = false;
GroupBox_OrderDetails.Visible = false;
}
private void label4_Click(object sender, EventArgs e)
{

}
private void groupBox1_Enter(object sender, EventArgs e)
{


}

private void groupBox3_Enter(object sender, EventArgs e)
{

}

private void label3_Click(object sender, EventArgs e)
{

}

private void groupBox4_Enter(object sender, EventArgs e)
{

}

private void panel1_Paint(object sender, PaintEventArgs e)
{

}

private void label1_Click(object sender, EventArgs e)
{

}
/* This Event Handler load once Start button is clicked.
*It has  Validation for ServerName which should be Alphabets only and it should not be empty.
* It has Validation for Table Number text box which should be Numeric only and it should not be empty.
* Once it passe all the validation than it moves to Pizza menu.
* Here Group box containing Pizza menu and PanelTwo cantaing Order button made visible. 
*/
private void button1_Click(object sender, EventArgs e)
{

GroupBoxPizzaMenu.Enabled = true;
String AllowedChars = "[a-zA-Z]";// Regular expression is Used for matching charecter entered in ServerName Text Box.
ServerName = S_Name.Text;
if (Regex.IsMatch(ServerName, AllowedChars)) // IsMatch() function is Used to Match the entered charecters with Valid Charecters. 
{
try
{
String Tab_Name = T_No.Text;
if (Tab_Name != "" && int.Parse(Tab_Name) > 0)
{
GroupBoxPizzaMenu.Visible = true;
PanelOne.Visible = false;
PanelTwo.Visible = true;
GroupBox_CompanyDetails.Visible = false;
GroupBox_OrderDetails.Visible = false;
M_pizza.Focus();
M_pizza.SelectAll();

this.Text = S_Name.Text + " " + "@" + "Table Number" + " " + T_No.Text;
}
else
{
MessageBox.Show("Enter a Value in Table Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
//Exception catch block for entering non-Numeric Charecters in Table Number Text box.
catch
{
MessageBox.Show("Enter a Numeric Value in Table Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}

else
{
MessageBox.Show("Enter a Value in Server Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}

}

/*
* This Event Handler load the Order Button.
* The entered Pizza quantites passes through following conitions: 
* 1.All Pizza quantities should not be zero.
* 2.should not be blank.
* 3.Any of the Pizza quanties can be Zero (not All).
After this Order is generated.
Order generates details about following:
1. Total Number of pizza's ordered.
2. Total table Receipts.
3. Server Name.

For every Total table Receipts SURCHARGE of 2.49 Euros is added after each transaction. 
*/
         
       
private void button2_Click(object sender, EventArgs e)
{
            
try
{
MPizza = int.Parse(M_pizza.Text);
if (MPizza >= 0 && M_pizza.Text != " ") 
// Exception Handling for Margherita Pizza qunatity text Box. 
{
try
{
PepPizza = int.Parse(P_Pizza.Text);
if (PepPizza >= 0 && P_Pizza.Text != " ") 
//Exception Handling for Pepperoni Pizza qunatity text Box.
{
try
{
HamPizza = int.Parse(H_Pizza.Text); 
//Exception Handling for HamPineapple Pizza qunatity text Box.
if (HamPizza >= 0 && H_Pizza.Text != "")
{
//Exception Handling for If all Pizza qunaties are Zero.
if (MPizza == 0 && PepPizza == 0 && HamPizza == 0)   
{
MessageBox.Show(" Please Enter the Pizza quantity properly  \n" + "The Quantity  of All Pizza type should not be empty to generate Order ");
                                   
}
else
{
int TotalPizzas, Transactions = 0, Total_NumberOfPizzas = 0;
//Constant SURCHARGE declared as 2.49Euros.
const decimal SURCHARGE = 2.49m;  
ServerName = S_Name.Text;
TotalPizzas = (MPizza + PepPizza + HamPizza);
TableOrderReceipts = Convert.ToDecimal( (9 * MPizza) + (11.50 * PepPizza) + (12.79 * HamPizza))+ SURCHARGE;
labelServer_Name.Text = ServerName.ToString();
labelTotal_Pizzas.Text = TotalPizzas.ToString();
labelTotalOrder_Receipts.Text = "€" + TableOrderReceipts.ToString();
Total_NumberOfPizzas += TotalPizzas;
Transactions += 1;
No_of_Pizzas.Add(Total_NumberOfPizzas);
TotalCompanyReceipts.Add(TableOrderReceipts);
TotalCompanyTransctns.Add(Transactions);
GroupBoxPizzaMenu.Enabled = false;
PanelOne.Visible = false;
PanelTwo.Visible = true;
GroupBox_CompanyDetails.Visible = false;
GroupBox_OrderDetails.Visible = true;

var SPlit_Sname = S_Name.Text.Split(' ');
this.Text = SPlit_Sname[0] + "@" + " Table Number " + T_No.Text; 
//Split String function used to split the ServerName and Just print the First Name of Server.
}
}
else
{
MessageBox.Show("Enter a Value in HamPineapple Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
catch
{
MessageBox.Show("Enter a Numeric Value in HamPineapple Pizza Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
}

else
{
MessageBox.Show("Enter a Value in Pepperoni Pizza Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
catch
{
MessageBox.Show("Enter a Numeric Value in Pepperoni Pizza Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
else
{
MessageBox.Show("Enter a Value in Margherita Pizza Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
catch
{
MessageBox.Show("Enter a Numeric Value in Margherita Pizza Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}


       
private void label10_Click(object sender, EventArgs e)
{

}

private void label4_Click_1(object sender, EventArgs e)
{

}

private void pictureBox2_Click(object sender, EventArgs e)
{

}

private void label1_Click_1(object sender, EventArgs e)
{

}
/*
* This Event Handler display the Company Summary details.
* Once Summary button is Clicked it calculate the folllowing:
* 1. Total Company receipts.
* 2. Total Number of Pizza's.
* 3. Total Number of Transactions.
* 4. Average Transactions of the receipts.
*/
private void button4_Click(object sender, EventArgs e)
{
//Local variable declaration sections.
decimal NetTransaction = 0, NetReceipts = 0;
int NetPizza = 0;
                 
foreach (int Transaction in TotalCompanyTransctns)
            
NetTransaction = NetTransaction + Transaction;
            
labelTotalCompany_Transactions.Text = NetTransaction.ToString();
foreach (int Total_NumberofPizzas in No_of_Pizzas)        
{
// Calculating Total Number of Pizza's.
NetPizza = NetPizza + Total_NumberofPizzas;
}
labelTotalNumber_Pizzas.Text = NetPizza.ToString();
foreach (decimal TableOrderReceipts in TotalCompanyReceipts)
{
// Calculaitng Total Number of receipts.
NetReceipts = NetReceipts + TableOrderReceipts;
}
labelTotalCompany_Receipts.Text ="€"+NetReceipts.ToString();
// Calculating Average transaciton.
AvgTransaction = (NetReceipts / NetTransaction);                
labelAverageCompany_Transaction.Text = "€" + AvgTransaction.ToString();
GroupBoxPizzaMenu.Visible = false;
PanelOne.Visible = false;
PanelTwo.Visible = true;
BtnOrder.Enabled = false;
GroupBox_CompanyDetails.Visible = true;
GroupBox_OrderDetails.Visible = false;
this.Text = " Sult Company Summary Data";
}

/*
* This Event Handler closes the application.
*/
private void ExitButton_Click(object sender, EventArgs e)
{
Close();
}
/*
* This Event Handler Clears everything for the Next table Order.
* it intialise the Pizza quantity text boxes and PanelOne  to Zero for next table order. 
*/
private void button3_Click(object sender, EventArgs e)
{
GroupBoxPizzaMenu.Visible = false;
PanelOne.Visible = true;
PanelTwo.Visible = false;
GroupBox_CompanyDetails.Visible = false;
GroupBox_OrderDetails.Visible = false;
S_Name.Text = "";
T_No.Text = "";
M_pizza.Text = "0";
H_Pizza.Text = "0";
P_Pizza.Text = "0";
this.Text = " Welcome to Sult Bar & Resturant";
}
}
}
