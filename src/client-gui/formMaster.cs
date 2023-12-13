namespace TreeGUI;
public partial class formMaster : Form {
    public const int FORM_BORDER_HEIGHT = 54;
    public const int FORM_BORDER_WIDTH = 22;
    public static Form? ChildForm { get; set; }

    public formMaster() {
        InitializeComponent();

        // Setup events
        FormClosing += Form_Close;

        // Format this form
        MinimumSize = GetSize();
        Size = MinimumSize;

        // Display the first form
        DisplayFormAfterSplash(new formHome());
    }

    /// <summary>
    /// Gets the initial size of the master form
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    private static Size GetSize() {
        Size workingArea;

        try {
            workingArea = Screen.PrimaryScreen!.WorkingArea.Size;
        }
        catch (NullReferenceException) {
            throw new NullReferenceException("You don't seem to have a screen on your computer?!?!");
        }

        int width = workingArea.Width / 3;

        int height = (int)(width * 2f / 3);

        return new Size(width + FORM_BORDER_WIDTH, height + FORM_BORDER_HEIGHT);
    }

    public void DisplayForm(Form form) {
        ChildForm = form;

        // Setup form display settings
        ChildForm.TopLevel = false;
        ChildForm.Dock = DockStyle.Fill;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.Enabled = true;
        ChildForm.Visible = true;

        // Display in panel
        pnlFormHolder.Controls.Clear();
        pnlFormHolder.Controls.Add(ChildForm);
        pnlFormHolder.Show();
    }

    public void DisplayFormInBackground(Form form) {
        ChildForm = form;

        // Setup form display settings
        ChildForm.TopLevel = false;
        ChildForm.Dock = DockStyle.Fill;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.Visible = false;
        ChildForm.Enabled = true;

        // Display in panel
        pnlFormHolder.Controls.Add(ChildForm);
        ChildForm.SendToBack();
        ChildForm.Visible = true;
        pnlFormHolder.Show();
    }

    public async void DisplayFormAfterSplash(Form form) {
        formSplash splashScreen = new formSplash();
        DisplayForm(splashScreen);
        DisplayFormInBackground(form);

        await splashScreen.SimulateLoading();

        form.BringToFront();
        pnlFormHolder.Controls.Remove(splashScreen);
    }

    public void Form_Close(object? sender, EventArgs e) {
        formHome.Tree.Dispose();
    }
}
