namespace MyTask
{


    public class MyBuildTask : Microsoft.Build.Utilities.Task
    {
        private string outputFile;

        [Microsoft.Build.Framework.Required]
        public string OutputFile
        {
            get { return outputFile; }
            set { outputFile = value; }
        }

        public override bool Execute()
        {
            Log.LogWarning("test message:" + this.outputFile);
            return true;
        }
    }
}
