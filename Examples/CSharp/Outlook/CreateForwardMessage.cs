﻿using Aspose.Email.Mapi;
using Aspose.Email.Tools;

/* This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET 
   API reference when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq 
   for more information. If you do not wish to use NuGet, you can manually download 
   Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
   install it and then add its reference to this project. For any issues, questions or suggestions 
   please feel free to contact us using https://forum.aspose.com/c/email            
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class CreateForwardMessage
    {
        public static void Run()
        {
            // ExStart:CreatForwardMessage
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();

            MapiMessage originalMsg = MapiMessage.FromFile(dataDir +"message1.msg");
            ForwardMessageBuilder builder = new ForwardMessageBuilder();
            builder.AdditionMode = OriginalMessageAdditionMode.Textpart;
            MapiMessage forwardMsg = builder.BuildResponse(originalMsg);
            forwardMsg.Save(dataDir + "forward_out.msg");
            // ExEnd:CreatForwardMessage
        }

    }
}
