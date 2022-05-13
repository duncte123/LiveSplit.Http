using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public class HttpComponent : IComponent
    {
        public HttpComponent(LiveSplitState state)
        {
            //
        }

        public string ComponentName { get; }
        public float HorizontalWidth { get; }
        public float MinimumHeight { get; }
        public float VerticalHeight { get; }
        public float MinimumWidth { get; }
        public float PaddingTop { get; }
        public float PaddingBottom { get; }
        public float PaddingLeft { get; }
        public float PaddingRight { get; }
        public IDictionary<string, Action> ContextMenuControls { get; }
        
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            throw new NotImplementedException();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            throw new NotImplementedException();
        }

        public void SetSettings(XmlNode settings)
        {
            throw new NotImplementedException();
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            throw new NotImplementedException();
        }
    }
}