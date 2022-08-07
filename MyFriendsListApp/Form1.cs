using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsListApp
{
    public partial class Form1 : Form
    {
        List<String> myFriends = new List<String>();
        //binding source is an intermediate link between the list and the listbox
        BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            //assign bindingSource a value of DataSource and become as myFriends
            bindingSource.DataSource = myFriends;
        }


        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            // add friends from the textbox to the myfriends list
            myFriends.Add(txt_newFriend.Text);
            listBox1.DataSource = bindingSource;
            //update the list
            bindingSource.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " in the list ";
            txt_newFriend.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_five_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = bindingSource;
            myFriends.Add("Steve");
            myFriends.Add("Toni");
            myFriends.Add("Leni");
            myFriends.Add("Linda");
            myFriends.Add("lore");
            bindingSource.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " in the list.";

        }

        private void btn_ascending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bindingSource.ResetBindings(false);
        }

        private void btn_descending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bindingSource.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            myFriends.Clear();
            bindingSource.ResetBindings(false);
        }
    }
}
