﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using IxMilia.Dxf.Collections;

namespace IxMilia.Dxf.Entities
{
    public partial class DxfInsert : IDxfItemInternal
    {
        private DxfPointerList<DxfAttribute> _attributes = new DxfPointerList<DxfAttribute>();
        private DxfPointer _seqendPointer = new DxfPointer(new DxfSeqend());

        public IList<DxfAttribute> Attributes { get { return _attributes; } }

        public DxfSeqend Seqend
        {
            get { return _seqendPointer.Item as DxfSeqend; }
            set { _seqendPointer.Item = value; }
        }

        IEnumerable<DxfPointer> IDxfItemInternal.GetPointers()
        {
            foreach (var att in _attributes.Pointers)
            {
                yield return att;
            }

            yield return _seqendPointer;
        }

        protected override void AddTrailingCodePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            foreach (var attribute in Attributes)
            {
                pairs.AddRange(attribute.GetValuePairs(version, outputHandles));
            }

            if (Seqend != null)
            {
                pairs.AddRange(Seqend.GetValuePairs(version, outputHandles));
            }
        }
    }
}
