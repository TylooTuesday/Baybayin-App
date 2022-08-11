using System;
using System.Collections.Generic;
using System.Text;

namespace baybayinapp.Models
{
    internal class TracingCR
    {
        public static string PredictionUrl = "https://southcentralus.api.cognitive.microsoft.com/";
        public static string CustomVisionPredictionApiKey = "a0a99100bb034962a0122402df397e31";

        public static Guid TracingProjectId = new Guid("77e17ebe-6372-4465-a30f-73c41d3f4cbc");
        public static string TracingIterationName = "Iteration4";

        public static Guid OCRProjectId = new Guid("9ad099e3-cfed-4b65-a507-9eb26a569c23");
        public static string OCRIterationName = "BaybayinSulat";
    }
}
