using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratosphen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }

        private delegate List<int> Eratosphen_alg(int maxValue);
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                Eratosphen_alg er = new Eratosphen_alg(eratosphen);
                AsyncCallback cb = new AsyncCallback(CallBackMethod);
                er.BeginInvoke(maxValue, cb, er);
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
                ResultLabel.Text = resultText.ToString();
            }           

        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            Eratosphen_alg er = (Eratosphen_alg)ar.AsyncState;
            str = string.Join(" ", er.EndInvoke(ar));
            
            ResultLabel.Invoke(PrintDlegateFunc, new object[] { str });
        }
                
        private List<int> eratosphen(int maxValue)
        {
            List<int> list = new List<int> { };
            
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        list.Add(trial);
                    }
                }
                                  
            return list;
        }

        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        void PrintFunc(string str)
        {
            ResultLabel.Text = str;
        }

    }

}
