using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fundamentals.ChapterInterfaces;

namespace Fundamentals.Tests.ChapterInterfacesTest
{
    [TestFixture]
    public class TextObjectTest
    {
        [Test]
        public void SimpleExampleScaleTextObject()
        {
            TextObject textObject = new TextObject("Textbox A");

            IScalable scalable = (IScalable)textObject;

            scalable.ScaleX(0.5f);
            scalable.ScaleY(0.5f);
        }

        [Test]
        public void WorkingWithInterfaceScaleDiagramObject()
        {
            DiagramObject[] diagramObjects = new DiagramObject[10];
            diagramObjects[0] = new DiagramObject();
            diagramObjects[1] = new TextObject("Text Dude");
            diagramObjects[2] = new TextObject("Text Backup");

            // array gets initialized here, with classes that
            // derive from DiagramObject. Some of them implement
            // IScalable.
            foreach(DiagramObject diagramObject in diagramObjects)
            {
                if(diagramObject is IScalable)
                {
                    IScalable scalable = (IScalable)diagramObject;
                    scalable.ScaleX(0.5f);
                    scalable.ScaleY(0.5f);
                }
            }
        }
        [Test]
        public void AsOperatorScaleDiagramObject()
        {
            DiagramObject[] diagramObjects = new DiagramObject[10];
            diagramObjects[0] = new DiagramObject();
            diagramObjects[1] = new TextObject("Text Dude");
            diagramObjects[2] = new TextObject("Text BackUp");

            foreach(DiagramObject diagramObject in diagramObjects)
            {
                IScalable scalable = diagramObject as IScalable;
                if(scalable != null)
                {
                    scalable.ScaleX(0.5f);
                    scalable.ScaleY(0.5f);
                }
            }
        }
    }
}
