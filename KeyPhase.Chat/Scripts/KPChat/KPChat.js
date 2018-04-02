var user = JSON.parse($.cookie('KPUser'));
var displayName = {
    FirstName: user.FirstName,
    FullName: user.FirstName + ' ' + user.LastName
}
var userCount = 0;

$(function () {
    //showModalUserNickName();
    startChartHub();
});

function showModalUserNickName() {
    $("#dialog").dialog({
        modal: true,
        buttons: {
            Ok: function () {
                $(this).dialog("close");
                startChartHub();
            }
        }
    });
}

function updateUserCount() {
    $('.onlineUsers-count').text(userCount);
}

function startChartHub() {
    var chat = $.connection.chatHub;

    // Get the user name.
    
    chat.client.differentName = function (name) {
        chat.server.notify(displayName.FirstName, $.connection.hub.id);
    };

    chat.client.online = function (name) {
         //Update list of users
        if (name == displayName)
            userCount++;
        else {
            userCount++;
            //$('#onlineusers').append('<div class="border">' + name + '</div>');
            //$("#users").append('<option value="' + name + '">' + name + '</option>');
        }
        updateUserCount();
    };

    chat.client.enters = function (name) {
        $('#chatlog').append('<div style="font-style:italic; "color: #44bd32;font-weight: 100;"><i>' + name + ' is now online.</i></div>');
        $("#users").append('<option value="' + name + '">' + name + '</option>');
        //$('#onlineusers').append('<div class="border">' + name + '</div>');
    };
    // Create a function that the hub can call to broadcast chat messages.
    chat.client.broadcastMessage = function (name, message) {
        //Interpret smileys
        message = message.replace(":)", "<img src=\"/images/smile.gif\" class=\"smileys\" />");
        message = message.replace("lol", "<img src=\"/images/laugh.gif\" class=\"smileys\" />");
        message = message.replace(":o", "<img src=\"/images/cool.gif\" class=\"smileys\" />");

        //display the message
        $('#chatlog').append('<div class="border chatlog-message"><span class="chatlog-user" title="' + displayName.FullName + '">' + name + '</span>: ' + message + '</div>');
    };
  
    chat.client.disconnected = function (name) {
        //Calls when someone leaves the page
        $('#chatlog').append('<div style="font-style:italic;color: #e84118;font-weight: 100;"><i>' + name + ' is now offline.</i></div>');
        //$('#onlineusers div').remove(":contains('" + name + "')");
        userCount--;
        updateUserCount();
        $("#users option").remove(":contains('" + name + "')");
    }

    // Start the connection.
    $.connection.hub.start().done(function () {
        //Calls the notify method of the server
        chat.server.notify(displayName.FirstName, $.connection.hub.id);

        $('#btnsend').click(function () {
            chat.server.send(displayName.FirstName, $('#message').val());
            //if ($("#users").val() == "All") {
            //    // Call the Send method on the hub.
            //    chat.server.send(displayName, $('#message').val());
            //}
            //else {
            //    chat.server.sendToSpecific(displayName, $('#message').val(), $("#users").val());
            //}
            // Clear text box and reset focus for next comment.
            $('#message').val('').focus();
        });

    });
}
