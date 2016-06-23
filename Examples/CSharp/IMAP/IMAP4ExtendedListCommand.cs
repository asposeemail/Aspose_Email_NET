﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Email.Outlook.Pst;
using Aspose.Email;
using Aspose.Email.Imap;
using Aspose.Email.Outlook;

/* This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET 
   API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq 
   for more information. If you do not wish to use NuGet, you can manually download 
   Aspose.Email for .NET API from http://www.aspose.com/downloads, 
   install it and then add its reference to this project. For any issues, questions or suggestions 
   please feel free to contact us using http://www.aspose.com/community/forums/default.aspx            
*/

namespace Aspose.Email.Examples.CSharp.Email.IMAP
{
    class IMAP4ExtendedListCommand
    {
        public static void Run()
        {

            using (ImapClient client = new ImapClient("imap.gmail.com", 993, "username", "password"))
            {
                ImapFolderInfoCollection folderInfoCol = client.ListFolders("*");
                Console.WriteLine("Extended List Supported: " + client.ExtendedListSupported);
                foreach (ImapFolderInfo folderInfo in folderInfoCol)
                    switch (folderInfo.Name)
                    {
                        case "[Gmail]/All Mail":
                            Console.WriteLine("Has Children: " + folderInfo.HasChildren.ToString());
                            break;
                        case "[Gmail]/Bin":
                            Console.WriteLine("Bin has children? " + folderInfo.HasChildren);
                            break;
                        case "[Gmail]/Drafts":
                            Console.WriteLine("Drafts has children? " + folderInfo.HasChildren);
                            break;
                        case "[Gmail]/Important":
                            Console.WriteLine("Important has Children? " + folderInfo.HasChildren);
                            break;
                        case "[Gmail]/Sent Mail":
                            Console.WriteLine("Sent Mail has Children? " + folderInfo.HasChildren);
                            break;
                        case "[Gmail]/Spam":
                            Console.WriteLine("Spam has Children? " + folderInfo.HasChildren);
                            break;
                        case "[Gmail]/Starred":
                            Console.WriteLine("Starred has Children? " + folderInfo.HasChildren);
                            break;
                    }
            }
        }

    }
}