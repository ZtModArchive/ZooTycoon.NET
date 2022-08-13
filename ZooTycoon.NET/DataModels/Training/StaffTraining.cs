using ZooTycoon.NET.DataModels.Classes.Text;

namespace ZooTycoon.NET.DataModels.Training
{
    public class StaffTraining
    {
        public string TrainingIconName { get; set; } = string.Empty;
        public TranslatableText TrainingTooltip { get; set; } = new TranslatableText();
    }
}
