// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Diagnostics.EventSchemaTraceListener.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Diagnostics
{
  public partial class EventSchemaTraceListener : TextWriterTraceListener
  {
    #region Methods and constructors
    public override void Close()
    {
    }

    public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles)
    {
    }

    public EventSchemaTraceListener(string fileName)
    {
    }

    public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize)
    {
    }

    public EventSchemaTraceListener(string fileName, string name)
    {
    }

    public EventSchemaTraceListener(string fileName, string name, int bufferSize)
    {
    }

    public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption)
    {
    }

    public override void Fail(string message, string detailMessage)
    {
    }

    public override void Flush()
    {
    }

    protected override string[] GetSupportedAttributes()
    {
      return default(string[]);
    }

    public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, Object[] data)
    {
    }

    public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, Object data)
    {
    }

    public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, Object[] args)
    {
    }

    public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
    {
    }

    public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
    {
    }

    public override void Write(string message)
    {
    }

    public override void WriteLine(string message)
    {
    }
    #endregion

    #region Properties and indexers
    public int BufferSize
    {
      get
      {
        return default(int);
      }
    }

    public override bool IsThreadSafe
    {
      get
      {
        return default(bool);
      }
    }

    public long MaximumFileSize
    {
      get
      {
        return default(long);
      }
    }

    public int MaximumNumberOfFiles
    {
      get
      {
        return default(int);
      }
    }

    public TraceLogRetentionOption TraceLogRetentionOption
    {
      get
      {
        return default(TraceLogRetentionOption);
      }
    }

    public TextWriter Writer
    {
      get
      {
        return default(TextWriter);
      }
      set
      {
        Contract.Ensures(false);
      }
    }
    #endregion
  }
}
