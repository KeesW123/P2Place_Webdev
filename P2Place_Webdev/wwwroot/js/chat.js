"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
document.getElementById("messagesList").hidden = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").hidden = false;
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user}: ${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    const url = new URL(window.location.href);
    var receiver = url.searchParams.get("sellerEmail");
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendToUserGroupMessage", receiver, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});