using System;
using Xamarin.Forms;

namespace illam.Extensions
{
    public class RequiredTriggerAction : TriggerAction<Editor>
    {
        protected override void Invoke(Editor sender)
        {
            sender.BackgroundColor = string.IsNullOrEmpty(sender.Text) ? Color.Red : Color.Default;
        }
    }
}
