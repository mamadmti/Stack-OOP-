using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        public class Stack
        {
            public class Person
            {
                public String Name;
                public int Age;
            }

            List<Person> list = new List<Person>();

            public void push(string name, int age)
            {
                Person person = new Person();
                person.Name = name;
                person.Age = age;
                list.Add(person);
            }

            public Person pop()
            {
                if (list.Count < 1)
                {
                    MessageBox.Show("stack is empty please fill the stack first");
                    return null;
                };
                Person currentperson = new Person();
                currentperson.Name = list[list.Count - 1].Name;
                currentperson.Age = list[list.Count - 1].Age;
                list.Remove(list[list.Count - 1]);
                return currentperson;
            }

            public void Clear()
            {
                list.RemoveRange(0, list.Count);
            }

            public int CurrentCount()
            {
                return list.Count;
            }
        }
        




        public Stack stack = new Stack();

        private void button1_Click(object sender, EventArgs e)
        {
            
            stack.push(textBox1.Text, Int32.Parse(textBox3.Text));
            textBox1.Text = textBox3.Text = null;
            label2.Text = stack.CurrentCount().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text= stack.CurrentCount().ToString();
            var pop = stack.pop();
            if(pop==null){return;}
            textBox2.Text= pop.Name ;
            textBox4.Text = pop.Age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stack.Clear();
            label2.Text = stack.CurrentCount().ToString();
        }
    }
}
