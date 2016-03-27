/*
 * Created by SharpDevelop.
 * User: Nate
 * Date: 3/27/2016
 * Time: 12:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Collections;


namespace Bible_Verse_Generator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Random Rnum = new Random();
		SpeechSynthesizer talk = new SpeechSynthesizer();
		ArrayList verses = new ArrayList();
		
		int current;
		

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
	
					//adds verses to verses arraylist.
			verses.Add("I can do all things through Christ who strengthens me. \n Philippians 4:13");
			verses.Add("Trust in the LORD with all your heart, And lean not on your own understanding In all your ways acknowledge Him, And He shall direct your paths. \n Proverbs 3:5-6 ");
			verses.Add("For to me to live is Christ, and to die is gain.\n Philippians 1:21");
			verses.Add("And we know that all things work together for good to them that love God, to them who are the called according to his purpose.\n Romans 8:28");
			verses.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.\n John 3:16");
			verses.Add("And now these three remain: faith, hope and love. But the greatest of these is love.\n 1 Corinthians 13:13");
			verses.Add("A gentle answer turns away wrath, but a harsh word stirs up anger.\n Proverbs 15:1");
			verses.Add("The Lord is good, a refuge in times of trouble. He cares for those who trust in him.\n nahum 1:7");
			verses.Add("The Lord is good, a refuge in times of trouble. He cares for those who trust in him. \n Psalm 62:7");
			verses.Add("Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God.\n Philippians 4:6");
			
			current = randomnum();
			label1.Text = verses[current].ToString();

		}//end button1
		
		
		void Button2Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked == true)
			{
				talk.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
				talk.Speak(verses[current].ToString());
			}//end if
			else if(radioButton2.Checked == true)
			{
				talk.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
				talk.Speak(verses[current].ToString());
			}//end else
			else if(radioButton1.Checked == false && radioButton2.Checked == false)
			{
				MessageBox.Show("You must select a voice gender!");
			
			}
			
					
				
		
		
		}//end button2
		
			public int randomnum()
		{
			Random r1 = new Random();
			return r1.Next(0,9);
		}

	}
}
