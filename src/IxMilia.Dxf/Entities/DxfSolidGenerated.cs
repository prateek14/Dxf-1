// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;
using IxMilia.Dxf.Collections;

namespace IxMilia.Dxf.Entities
{

    /// <summary>
    /// DxfSolid class
    /// </summary>
    public partial class DxfSolid : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Solid; } }

        public DxfPoint FirstCorner { get; set; }
        public DxfPoint SecondCorner { get; set; }
        public DxfPoint ThirdCorner { get; set; }
        public DxfPoint FourthCorner { get; set; }
        public double Thickness { get; set; }
        public DxfVector ExtrusionDirection { get; set; }

        public DxfSolid()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.FirstCorner = DxfPoint.Origin;
            this.SecondCorner = DxfPoint.Origin;
            this.ThirdCorner = DxfPoint.Origin;
            this.FourthCorner = DxfPoint.Origin;
            this.Thickness = 0.0;
            this.ExtrusionDirection = DxfVector.ZAxis;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbShape"));
            pairs.Add(new DxfCodePair(10, FirstCorner?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, FirstCorner?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, FirstCorner?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(11, SecondCorner?.X ?? default(double)));
            pairs.Add(new DxfCodePair(21, SecondCorner?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(31, SecondCorner?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(12, ThirdCorner?.X ?? default(double)));
            pairs.Add(new DxfCodePair(22, ThirdCorner?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(32, ThirdCorner?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(13, FourthCorner?.X ?? default(double)));
            pairs.Add(new DxfCodePair(23, FourthCorner?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(33, FourthCorner?.Z ?? default(double)));
            if (this.Thickness != 0.0)
            {
                pairs.Add(new DxfCodePair(39, (this.Thickness)));
            }

            if (this.ExtrusionDirection != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, ExtrusionDirection?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, ExtrusionDirection?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, ExtrusionDirection?.Z ?? default(double)));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 10:
                    this.FirstCorner.X = pair.DoubleValue;
                    break;
                case 20:
                    this.FirstCorner.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.FirstCorner.Z = pair.DoubleValue;
                    break;
                case 11:
                    this.SecondCorner.X = pair.DoubleValue;
                    break;
                case 21:
                    this.SecondCorner.Y = pair.DoubleValue;
                    break;
                case 31:
                    this.SecondCorner.Z = pair.DoubleValue;
                    break;
                case 12:
                    this.ThirdCorner.X = pair.DoubleValue;
                    break;
                case 22:
                    this.ThirdCorner.Y = pair.DoubleValue;
                    break;
                case 32:
                    this.ThirdCorner.Z = pair.DoubleValue;
                    break;
                case 13:
                    this.FourthCorner.X = pair.DoubleValue;
                    break;
                case 23:
                    this.FourthCorner.Y = pair.DoubleValue;
                    break;
                case 33:
                    this.FourthCorner.Z = pair.DoubleValue;
                    break;
                case 39:
                    this.Thickness = (pair.DoubleValue);
                    break;
                case 210:
                    this.ExtrusionDirection.X = pair.DoubleValue;
                    break;
                case 220:
                    this.ExtrusionDirection.Y = pair.DoubleValue;
                    break;
                case 230:
                    this.ExtrusionDirection.Z = pair.DoubleValue;
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
