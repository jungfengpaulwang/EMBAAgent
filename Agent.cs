using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agent
{
    public class Export
    {
        private static readonly Lazy<Export> LazyInstance = new Lazy<Export>(() => new Export());
        public static Export Instance { get { return LazyInstance.Value; } }

        private Export() { }

        public static Agent.Viewer.SelectField GetSelectFieldForm()
        {
            return (new Agent.Viewer.SelectField());
        }

        public static System.Windows.Forms.Form GetProgressForm()
        {
            return (new Agent.Viewer.DoWork());
        }
    }
}