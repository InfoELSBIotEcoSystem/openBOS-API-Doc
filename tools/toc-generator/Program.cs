using System.Web;

int i = 0;
var docArgs = new DocToTOCArgument();

docArgs.outputFile = "toc.json";
docArgs.inputDir = args[i++];
docArgs.outputDir = args[i++];

if ( !Directory.Exists(docArgs.inputDir) ){
    throw new ArgumentException("Input dir must exist");
}
if ( !Directory.Exists(docArgs.outputDir) ){
    throw new ArgumentException("Output dir must exist");
}

for( ; i < args.Length; i++){
    if ( args[i].ToLower() == "--name"){
        docArgs.outputFile = args[i+1];
    }
}

string test = "I don&apos;t know if I need to register";
string result = HttpUtility.HtmlDecode(test);

new DocToTOC(docArgs).Generate();


