using System.Drawing;
using ImageManipulationTest.Model;

// grootte van brush
int brushSize = 8;

// nieuwe lijst met paden
List<WalkingPath> Paths = new List<WalkingPath>();
WalkingPath pathOne = new WalkingPath(103, 121, 225, 121);
WalkingPath PathTwo = new WalkingPath(225, 121, 225, 170);
WalkingPath PathThree = new WalkingPath(225, 170, 130, 170);
WalkingPath PathFour = new WalkingPath(130, 170, 130, 200);
Paths.Add(pathOne);
Paths.Add(PathTwo);
Paths.Add(PathThree);
Paths.Add(PathFour);

// Een nieuwe Image inladen als bitmap
// (dit path moet je even aanpassen als je code via github haalt)
// rechtklik op maze.PNG in de solution explorer en klik op "Copy Full Path" en vervang het
using Bitmap image = new Bitmap("X:\\Dev\\ImageManipulationTest\\ImageManipulationTest\\Img\\maze.PNG");

// Een nieuwe route met als parameters naam van de route, de bitmap en een lijst van paths
Route route = new Route("Entrance", image, Paths);

// een nieuwe pen met de kleur red en dikte 8
Pen redPen = new Pen(Color.Red, brushSize);

// de image als graphics inladen zodat we het kunnen manipuleren
var graphics = Graphics.FromImage(image);

// voor elk pad in routes kijken we of aantal condities kloppen.
// indien startx > endx betekent dat we naar links gaan
// startx < endx is naar rechts
// starty > endy is omlaag
// starty < endy is omhoog
foreach (var path in route.Paths)
{
    if (path.StartX > path.EndX)
        path.StartX = path.StartX + (brushSize / 2);
    if (path.StartX < path.EndX)
        path.StartX = path.StartX - (brushSize / 2);
    if (path.StartY > path.EndY)
        path.StartY = path.StartY + (brushSize / 2);
    if (path.StartY < path.EndY)
        path.StartY = path.StartY - (brushSize / 2);
    graphics.DrawLine(redPen, path.StartX, path.StartY, path.EndX, path.EndY);
}

// uiteindelijk slaan we de aangepaste image op in de "Output" map
// Deze directory moet je ook aanpassen als je het via github haalt
// rechtklik op "Output" in de file explorer en klik "Copy Full Path"
// vervang de string en vergeet niet om aan het einde een naam.PNG mee te geven zoals bijvoorbeeld test.PNG
image.Save(@"X:\Dev\ImageManipulationTest\ImageManipulationTest\Output\test.PNG");
