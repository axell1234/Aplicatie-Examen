using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Aplicatie_Examen
internal class ValidationBehaviour : Behavior<Editor>
{
    public ValidationBehaviour()
    {
    }

    protected override void OnAttachedTo(Editor entry)
    {
        entry.TextChanged += OnEntryTextChanged;
        base.OnAttachedTo(entry);
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    protected override void OnDetachingFrom(Editor entry)
    {
        entry.TextChanged -= OnEntryTextChanged;
        base.OnDetachingFrom(entry);
    }
}
}
void OnEntryTextChanged(object sender, TextChangedEventArgs args)
{
    ((Editor)sender).BackgroundColor = string.IsNullOrEmpty(args.NewTextValue) ? Color.Red : Color.Default;
}
}
