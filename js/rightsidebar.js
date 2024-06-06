window.openNav = () =>
{
    var width = 300;
    document.getElementById("sidepanel").style.left = `calc(100% - ${width}px)`;
    document.getElementById("sidepanel").style.width = `${width}px`;
}

window.closeNav = () =>
{
    document.getElementById("sidepanel").style.left = "100%";
    document.getElementById("sidepanel").style.width = "0";
}