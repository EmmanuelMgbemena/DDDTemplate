﻿using FXBLOOM.DomainLayer.CustomerAggregate.DTOs;
using FXBLOOM.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using static FXBLOOM.SharedKernel.Enumerations;

namespace FXBLOOM.DomainLayer.CustomerAggregate
{
    public class Document : ValueObject<Document>
    {
        public string IDNumber { get; private set; }
        public DocumentType DocumentType { get; private set; }

        internal static Document CreateDocument(DocumentDto documentDto)
        {
            return new Document();
        }
    }
}
