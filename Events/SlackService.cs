﻿using System;

namespace Events
{
    public class SlackService
    {
        public void OnDocumentationSent(object source, DocumentationPublishedHandler e)
        {
            Console.WriteLine("[Slack]: New documentation has been published: {0} ({1}...)", e.Document.Title, e.Document.Text[0..10]);
        }
    }
}