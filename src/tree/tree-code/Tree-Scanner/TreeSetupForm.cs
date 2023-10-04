using System.Diagnostics.CodeAnalysis;

namespace Tree_Scanner;

public partial class TreeSetupForm : Form
{
    List<string> Instructions = new List<string>();
    int index = 0;
    public TreeSetupForm()
    {
        InitializeComponent();
        CreateInstructionList();
        RichTextBoxDialogue.Text = Instructions[0];
    }

    void CreateInstructionList()
    {
        Instructions.Add("Welcome to the setup wizard, press next to continue");
        Instructions.Add("This is the Instruction panel and the black box at the bottom is the Error Panel");
        Instructions.Add("To start, place your laptop in a position where it can get a clear and level photo of the tree");
        Instructions.Add("Keep in mind the laptop will have to stay in this position for the duration of the mapping");
        Instructions.Add("When you're ready press the *Take Initial Photo* button to capture a photo.\n\n*NOTE* If the picture is not good enough, you can retake it");
        Instructions.Add("When the photo is adequate please press the *Register Corners* button and click on the top, bottom left and bottom right of the tree");
        Instructions.Add("When the corners have been captured submerge the room into darkness and press the *Map LEDs* button. This process will run without user input and may take a long time. A popup will appear when the process is finished");
    }

    private void BtnNext_Click(object sender, EventArgs e)
    {
        if (index < Instructions.Count - 1)
        {
            index++;
            RichTextBoxDialogue.Text = Instructions[index];
        }
    }

    private void BtnPrevious_Click(object sender, EventArgs e)
    {
        if (index > 0)
        {
            index--;
            RichTextBoxDialogue.Text = Instructions[index];
        }
    }

    void DisplayError(string message) => RichTextBoxErrors.AppendText($"\n{message}");
}