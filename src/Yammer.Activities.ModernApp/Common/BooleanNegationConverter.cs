﻿// ***********************************************************************
// Provided for Informational Purposes Only
//
// Apache 2.0 License
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may
// not use this file except in compliance with the License. You may obtain
// a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY 
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR 
// PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
// ***********************************************************************
// Assembly  : Yammer.Activities.ModernApp
// File      : BooleanNegationConverter.cs
//
// ***********************************************************************
using System;
using Windows.UI.Xaml.Data;

namespace Yammer.Activities.ModernApp.Common
{
	/// <summary>
	/// Value converter that translates true to false and vice versa.
	/// </summary>
	public sealed class BooleanNegationConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return !(value is bool && (bool)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return !(value is bool && (bool)value);
		}
	}
}
