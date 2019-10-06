using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.HelloCSharpWin
{
    public enum Operators { Add, Sub, Mul, Div } //열거형 데이터 타입 정의

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;    //새로운 숫자로 리플레이스
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        ////Click event Handler
        //private void HelloLabel_Click(object sender, EventArgs e)
        //{   

        //    int number1 = 1;
        //    int number2 = 2;

        //    int sum = number1 + number2;

        //    HelloLabel.Text = sum.ToString(); //int -> string = toString()
        //}

        //private void SumNumbers_Click(object sender, EventArgs e)
        //{
        //    int number1 = 0;
        //    int number2 = 0;

        //    if (String.IsNullOrWhiteSpace(Sum1.Text))
        //    {
        //        MessageBox.Show("Sum1에 숫자를 입력해주세요."); //메세지박스 띄움
        //        Sum1.Focus();
        //        return; //바로 함수에서 빠져나감
        //    }

        //    if(int.TryParse(Sum1.Text, out number1) == false)
        //    {
        //        MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요."); //메세지박스 띄움
        //        Sum1.SelectAll();
        //        Sum1.Focus();   //숫자를 바로 수정할 수 있는 상태
        //        return;
        //    }

        //    if (String.IsNullOrWhiteSpace(Sum2.Text))
        //    {
        //        MessageBox.Show("Sum2에 숫자를 입력해주세요."); //메세지박스 띄움
        //        return; //바로 함수에서 빠져나감
        //    }

        //    if (int.TryParse(Sum2.Text, out number2) == false)
        //    {
        //        MessageBox.Show("Sum2에 문자가 들어왔습니다. 숫자를 입력해주세요."); //메세지박스 띄움
        //        return;
        //    }

        //    int sum = Add(number1, number2);
        //    SumResult.Text = sum.ToString();
        //}


        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2) //function overloading
        {
            float sum = number1 + number2;
            return sum;
        }
        
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        //변수 = 0;

        //숫자 입력
        //더하기 버튼 - 숫자 완성, 변수와 숫자 합, 결과를 변수에 다시 저장
        //숫자 입력
        //더하기 버튼 - 계속 반복


        private void NumButton1_Click(object sender, EventArgs e)
        {
            //sender : 이벤트를 발생시킨 객체
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            //연산자 연속 두번 클릭에 대한 예외처리
            if (isNewNum == false)
            {

                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Add(Result, num);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, num);

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
