function doSomething() {
    //var num1 = 10;
    //num1 = num1 + "10";
    //alert(num1);
  greet().then(
        function (value) { display(value); },
        function (error) { display(error) }
    );
    console.log("Check");
}
function display(msg) {
    document.getElementById("p1").innerHTML = msg;
}
function checkDelay(usertime) {
    return new Promise(function (resolve)
    {
        setTimeout(resolve(100), usertime)
    });
}
async function greet() {
    var number = await setTimeout(async function () { alert('hello');return 200 },2000);
    var data = document.getElementById("txtGreet");
    if (data.value == '')
        throw new Error("Name is empty");
    return "Hello from greet to " + data.value + number;
}

