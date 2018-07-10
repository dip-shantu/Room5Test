//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;

//namespace Room5Test.Reports
//{
//    public class ReportingManager
//    {
//        //private static readonly ExtentReports _instance = new ExtentReports(TestContext.CurrentContext.TestDirectory + "\\TestResults.html");
//        static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter("extent.html");
//        public static readonly ExtentReports _instancce = new ExtentReports();
        



//        static ReportingManager() { }
//        private ReportingManager() { }
    

//        /// <summary>
//        /// Property to return the instance of the report.
//        /// </summary>
//        /// <value>
//        /// The instance.
//        /// </value>
//        public static ExtentReports Instance
//        {
//            get
//            {
//                _instancce.AttachReporter(htmlReporter);
//                return _instancce;
//            }
//        }
//    }
//}