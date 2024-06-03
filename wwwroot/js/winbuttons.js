window.setButtonsLikeWindows = () =>
{
    var winGrid = document.getElementsByClassName("win-grid");

    document.querySelectorAll(".win-grid").forEach((winGrid) => 
    {
        winGrid.addEventListener("mousemove", (grid) => {
            var x = grid.clientX;
            var y = grid.clientY;
            
            winGrid.querySelectorAll(".win-btn").forEach((button) => {
                var i = 0;
                if (i <= 1) {
                    let event = new MouseEvent("mousemove",
                        {
                            clientX: x,
                            clientY: y,
                            view: window
                        });
                    button.dispatchEvent(event);
                }
                i++;
            });
        });
    });
    
    function isMouseInside(node, x, y)
    {
        const rect = node.getBoundingClientRect();

        let _x = x - rect.left; //x position within the element.
        let _y = y - rect.top; //y position within the element.

        var isXInside = _x >= 0 && _x <= rect.width;
        var isYInside = _y >= 0 && _y <= rect.height;
        
        return isXInside && isYInside;
    }

    document.querySelectorAll(".win-btn").forEach((b) => {
        b.onmouseleave = (e) => {
            e.target.style.background = "transparent";
            b.style.borderImage = null;
        };

        b.addEventListener("mousemove", (e) => {

            var inside = isMouseInside(b, e.clientX, e.clientY);
            
            const rect = b.getBoundingClientRect();
            
            let x = e.clientX - rect.left; //x position within the element.
            let y = e.clientY - rect.top; //y position within the element.

            var isXInside = x < 0 || x > rect.width;
            var isYInside = y <0 || y > rect.height;

            var light = inside? 0.7 : 0.3;
            var border = inside? 0.2 : 0;
            var backgroundLight = inside? 0.1 : 0;

            // if (inside)
            {
                //1 - свечение фона
                //2 - задний фон
                //3 - свечение border
                b.style.background = `radial-gradient(circle at ${x}px ${y}px ,rgba(255,255,255,${backgroundLight}),rgba(255,255,255,0) ) padding-box, linear-gradient(rgb(34,37,41) 0 0) content-box, radial-gradient(20% 75% at ${x}px ${y}px , rgba(255,255,255,${light}),rgba(255,255,255,${border}) ) border-box`;
            }

            // b.style.borderImage = `radial-gradient(20% 75% at ${x}px ${y}px ,rgba(255,255,255,${light}),rgba(255,255,255,${border}) ) 1 / 3px / 0px stretch `;
        });
    });
}