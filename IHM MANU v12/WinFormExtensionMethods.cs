﻿/* The MIT License (MIT)
* 
* Copyright (c) 2015 Marc Clifton
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/

using System;
using System.Windows.Forms;

namespace Clifton.Core.ExtensionMethods
{
    public static class WinFormExtensionMethods
    {
        /// <summary>
        /// Asynchronous invoke on application thread.  Will return immediately unless invocation is not required.
        /// </summary>
        public static void BeginInvoke(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                // We want a synchronous call here!!!!
                control.BeginInvoke((Delegate)action);
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// Synchronous invoke on application thread.  Will not return until action is completed.
        /// </summary>
        public static void Invoke(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                // We want a synchronous call here!!!!
                control.Invoke((Delegate)action);
            }
            else
            {
                action();
            }
        }
    }
}