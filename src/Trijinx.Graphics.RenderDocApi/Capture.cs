using System;

namespace Trijinx.Graphics.RenderDocApi
{
    public readonly record struct Capture(int Index, string FileName, DateTime Timestamp)
    {
        public void SetComments(string comments)
        {
            RenderDoc.SetCaptureFileComments(FileName, comments);
        }
    }
}
