namespace DesktopCalculator
{
    public partial class MainForm : Form
    {
        private double Answer { get; set; }
        private double second { get; set; }
        private string Operator { get; set; }
        private string LastMove { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Operator = "1";
            LastMove = "1";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Operation.Text = "";
            Input.Text = "0";
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (!Input.Text.Equals("0"))
            {
                if (Input.Text.Length == 1)
                {
                    Input.Text = "0";
                }
                else
                {
                    Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
                }
            }
        }

        // Number Button
        private void Zero_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "0";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "0";
            }
            else
            {
                Input.Text += "1";
            }
            LastMove = "Number";
        }
        private void One_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || LastMove.Equals("Operator"))
            {
                Input.Text = "1";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "1";
            }
            else
            {
                Input.Text += "1";
            }
            LastMove = "Number";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "2";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "2";
            }
            else
            {
                Input.Text += "2";
            }
            LastMove = "Number";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "3";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "3";
            }
            else
            {
                Input.Text += "3";
            }
            LastMove = "Number";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "4";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "4";
            }
            else
            {
                Input.Text += "4";
            }
            LastMove = "Number";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "5";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "5";
            }
            else
            {
                Input.Text += "5";
            }
            LastMove = "Number";
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "6";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "6";
            }
            else
            {
                Input.Text += "6";
            }
            LastMove = "Number";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "7";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "7";
            }
            else
            {
                Input.Text += "7";
            }
            LastMove = "Number";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "8";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "8";
            }
            else
            {
                Input.Text += "8";
            }
            LastMove = "Number";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (Input.Text.Equals("0") || Input.Text.Equals("Error") || !LastMove.Equals("Number"))
            {
                Input.Text = "9";
            }
            else if (Operation.Text.Contains("="))
            {
                Operation.Text = "";
                Input.Text = "9";
            }
            else
            {
                Input.Text += "9";
            }
            LastMove = "Number";
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (Operation.Text.Contains("=") || isOperator(Operator))
            {
                Operation.Text = "";
                Input.Text = "0.";
            }
            else if (Input.Text.Contains("."))
            {
                Input.Text = "Error";
            }
            else
            {
                Input.Text = Input.Text.Insert(Input.Text.Length, ".");
            }
            LastMove = "Number";
        }
        private void PN_Click(object sender, EventArgs e)
        {
            if (Input.Text.Contains("-"))
            {
                Input.Text = Input.Text.Substring(1, Input.Text.Length-1);
            }
            else
            {
                Input.Text = Input.Text.Insert(0, "-");
            }
            LastMove = "Number";
        }

        // Operator Button
        private void Addition_Click(object sender, EventArgs e)
        {
            Operator = "+";
            Answer = double.Parse(Input.Text);
            Operation.Text = $"{ Answer}{ Operator}";
            LastMove = "Operator";
        }
        private void Subtraction_Click(object sender, EventArgs e)
        {
            Operator = "-";
            Answer = double.Parse(Input.Text);
            Operation.Text = $"{ Answer}{ Operator}";
            LastMove = "Operator";
        }
        private void Multiplication_Click(object sender, EventArgs e)
        {
            Operator = "¡Á";
            Answer = double.Parse(Input.Text);
            Operation.Text = $"{ Answer}{ Operator}";
            LastMove = "Operator";
        }
        private void Division_Click(object sender, EventArgs e)
        {
            Operator = "-";
            Answer = double.Parse(Input.Text);
            Operation.Text = $"{ Answer}{ Operator}";
            LastMove = "Operator";
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (isOperator(Operator))
            {
                if (!LastMove.Equals("Equal"))
                {
                    second = double.Parse(Input.Text);
                }
                switch (Operator)
                {
                    case "+":
                        Operation.Text = $"{ Answer} { Operator} { second} =";
                        Input.Text=(Answer+second).ToString();
                        break;
                    case "-":
                        Operation.Text = $"{ Answer} { Operator} { second} =";
                        Input.Text = (Answer - second).ToString();
                        break;
                    case "¡Á":
                        Operation.Text = $"{ Answer} { Operator} { second} =";
                        Input.Text = (Answer * second).ToString();
                        break;
                    default:
                        Operation.Text = $"{ Answer} { Operator} { second} =";
                        Input.Text = (Answer / second).ToString();
                        break;
                }
                Answer = double.Parse(Input.Text);
                LastMove = "Equal";
            }
        }

        // Additional Function
        private void Binary_Click(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(Input.Text,out n))
            {
                if (n > 0)
                {
                    List<int> resultList = new List<int> {};
                    int num = Int32.Parse(Input.Text);
                    while (num != 0)
                    {
                        if (num % 2 == 0)
                        {
                            resultList.Add(0);
                        }
                        else
                        {
                            resultList.Add(1);
                        }
                        num /= 2;
                    }
                    Operation.Text = $"BIN({ Input.Text})";
                    resultList.Reverse();
                    string result = "";
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        result += resultList[i].ToString();
                    }
                    Input.Text = result;
                }
                else
                {
                    Input.Text = "Error";
                }
            }
            else
            {
                Input.Text = "Error";
            }
        }

        // Help Function
        private Boolean isOperator(string a)
        {
            string operators= "+-¡Á/";
            if (operators.Contains(a))
            {
                return true;
            }
            return false;
        }

    }
}