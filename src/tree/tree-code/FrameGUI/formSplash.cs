using System.Diagnostics;

namespace TreeGUI;
public partial class formSplash : Form {
    private const int FRAME_TIME = 5;
    public formSplash() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Position the label of the quiz title - due to autoscaling it does nout automatically position itself correctly
        lblTitle.Location = new Point((Width - lblTitle.Width) / 2, lblTitle.Location.Y);
    }

    public async Task SimulateLoading(int milliseconds = 1000) {
        Stopwatch sw = new();
        pnlProgress.Size = new(0, pnlProgress.Height);
        sw.Start();
        while (sw.ElapsedMilliseconds < milliseconds) {
            pnlProgress.Size = new Size((int)((pnlProgressBack.Width - 8) * ((float)sw.ElapsedMilliseconds / milliseconds)), pnlProgress.Height);
            await Task.Delay(FRAME_TIME);
        }
        sw.Stop();
    }
}
