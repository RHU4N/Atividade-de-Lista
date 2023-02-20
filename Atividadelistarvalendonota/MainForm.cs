/*
 * Created by SharpDevelop.
 * User: PCZIN-MONSTRO
 * Date: 08/03/2022
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atividadelistarvalendonota
{

	public partial class MainForm : Form
	{
		
		public string[] nome=new string[20];
		
		public MainForm()
		{
			InitializeComponent();
			
			label1.Visible=false;
			label2.Visible=false;
			label3.Visible=false;
			label4.Visible=false;
			listBox1.Visible=false;
			listBox2.Visible=false;
			listBox3.Visible=false;
			label6.Visible=false;
			label7.Visible=false;
			label8.Visible=false;
			label9.Visible=false;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			 try{
				richTextBox1.LoadFile("arquivo.txt",RichTextBoxStreamType.PlainText);
				}
			 catch
			    {		
		     	}			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			panel1.Visible=false;
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			
			for(int nm=0; nm<20; nm++)
              {
				nome[nm] = richTextBox1.Lines[nm];	
			  }    
               
			
				float soma = 0;	              
              
				foreach (string linhaNota in richTextBox1.Lines)
				{
					if (linhaNota!= "")
					{
						string[] dados = linhaNota.Split('\t');
						string nomes = dados[0];
						string salario = dados[1];
						string setor = dados[2];
						
						listBox1.Items.Add(dados[0]);
						listBox2.Items.Add(dados[1]);
						listBox3.Items.Add(dados[2]);
						
						float result = float.Parse(dados[1]);
						soma+=result;
					}
				label6.Text = soma.ToString();
				label1.Visible=true;
			    label2.Visible=true;
				label3.Visible=true;
				label4.Visible=true;
				listBox1.Visible=true;
				listBox2.Visible=true;
				listBox3.Visible=true;
				label6.Visible=true;
				}
	    }
		
		void Button2Click(object sender, EventArgs e)
		{
			
			listBox4.Items.Clear();
			listBox5.Items.Clear();
			
			
				
 		        float soma = 0;	
 		        
				foreach (string linhaNotas in nome)
				{

				string [] dados = linhaNotas.Split('\t');
				string nomes = dados[0];
				float salario = float.Parse(dados[1]);
				string setor = dados[2]; 
                string pegasetor = dados[2];
					
				if (pegasetor[0] == textBox3.Text[0])	
	           	  {
					
					soma += salario;
					listBox4.Items.Add(dados[0]);
					listBox5.Items.Add(dados[1]);
					textBox2.Text = soma.ToString();
	          	  }
					
				
				} //FOREACH
				
				
				
				
    	    
  		}
		
		void Button3Click(object sender, EventArgs e)
		{
		
			richTextBox2.Clear();
			
			
			var listBotao = new List<DadosTextBox>();

				foreach (string linhaBlNota in richTextBox1.Lines){

				if (linhaBlNota != ""){

						string[] dados = linhaBlNota.Split('\t');

                    	listBotao.Add(new DadosTextBox{

                        Setor = int.Parse(dados[2]),

                        Nome = dados[0],

                        Salario = float.Parse(dados[1])

                    });

                }
				

            }


            listBotao = listBotao.OrderBy(x => x.Setor).ToList();


				foreach (var dadoBotao in listBotao){

                richTextBox2.Text += dadoBotao.Setor.ToString() + '\t';
                richTextBox2.Text += dadoBotao.Nome + '\t';
                richTextBox2.Text += dadoBotao.Salario.ToString() + '\n';
                
                

                try{
				richTextBox2.SaveFile("Secao.txt",RichTextBoxStreamType.PlainText);
				}
			 catch
			    {		
		     	}	
			
			 

            }
             label7.Visible=true;
                label8.Visible=true;
                label9.Visible=true;
			 

        }
		

	}
}

