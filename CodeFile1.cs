using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class ReadInt
{
    static void Main()
    {
        string res, txt;
        int year = 2020, age, born;
        res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
        born = Int32.Parse(res);
        age = year - born;
        txt = "Вам " + age + " лет!";
        MessageBox.Show(txt, "Возраст");
    }
}
