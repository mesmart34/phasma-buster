function isMouseInside(node, x, y)
{
    const rect = node.getBoundingClientRect();

    let _x = x - rect.left; //x position within the element.
    let _y = y - rect.top; //y position within the element.

    var isXInside = _x >= 0 && _x <= rect.width;
    var isYInside = _y >= 0 && _y <= rect.height;

    return isXInside && isYInside;
}

function removeLiteners (el)
{
    elClone = el.cloneNode(true);
    el.parentNode.replaceChild(elClone, el);
}

window.setButtonsLikeWindows = () =>
{
    // var winGrid = document.getElementsByClassName("rz-body");
    
    var winGrid = document.getElementById("app");

    document.querySelectorAll("div[id=app]").forEach((winGrid) => 
    {
        function mousemovef (grid)
        {
            var x = grid.clientX;
            var y = grid.clientY;

            winGrid.querySelectorAll(".win-btn").forEach((button) =>
            {
                var i = 0;
                if (i <= 1)
                {
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
        }
        winGrid.removeEventListeners("mousemove");
        winGrid.addEventListener("mousemove", mousemovef);
    });

    document.querySelectorAll(".win-btn").forEach((b) => 
    {
        function mouseleavef (e)
        {
            e.target.style.background = "linear-gradient(rgb(34,37,41) 0 0) content-box";
            b.style.borderImage = null;
        }
        
        b.removeEventListeners("mouseleave");
        b.addEventListener("mouseleave", mouseleavef);

        function mousemoveff (e)
        {
            var inside = isMouseInside(b, e.clientX, e.clientY);

            const rect = b.getBoundingClientRect();

            let x = e.clientX - rect.left; //x position within the element.
            let y = e.clientY - rect.top; //y position within the element.

            var light = inside? 0.7 : 0.3;
            var border = inside? 0.2 : 0;
            var backgroundLight = inside? 0.1 : 0;

            //1 - свечение фона
            //2 - задний фон
            //3 - свечение border
            b.style.background = `radial-gradient(circle at ${x}px ${y}px ,rgba(255,255,255,${backgroundLight}),rgba(255,255,255,0) ) padding-box, linear-gradient(rgb(34,37,41) 0 0) content-box, radial-gradient(20% 75% at ${x}px ${y}px , rgba(255,255,255,${light}),rgba(255,255,255,${border}) ) border-box`;

            // b.style.borderImage = `radial-gradient(20% 75% at ${x}px ${y}px ,rgba(255,255,255,${light}),rgba(255,255,255,${border}) ) 1 / 3px / 0px stretch `;
        }
        b.removeEventListeners("mousemove");
        b.addEventListener("mousemove", mousemoveff);
    });
}

//========================removerEventsListeners===================================

(function()
{
    let target = EventTarget.prototype;
    let functionName = 'addEventListener';
    let func = target[functionName];

    let symbolHidden = Symbol('hidden');

    function hidden(instance)
    {
        if(instance[symbolHidden] === undefined)
        {
            let area = {};
            instance[symbolHidden] = area;
            return area;
        }

        return instance[symbolHidden];
    }

    function listenersFrom(instance)
    {
        let area = hidden(instance);
        if(!area.listeners) { area.listeners = []; }
        return area.listeners;
    }

    target[functionName] = function(type, listener)
    {
        let listeners = listenersFrom(this);

        listeners.push({ type, listener });

        func.apply(this, [type, listener]);
    };

    target['removeEventListeners'] = function(targetType)
    {
        let self = this;

        let listeners = listenersFrom(this);
        let removed = [];

        listeners.forEach(item =>
        {
            let type = item.type;
            let listener = item.listener;

            if(type == targetType)
            {
                self.removeEventListener(type, listener);
            }
        });
    };
})();