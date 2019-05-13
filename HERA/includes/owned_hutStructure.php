<div class="hutbox non-printable">
    <form class="hut_info" action="includes/addTickets.php" method="post">
        <div class="hut_idbox">
            <div class="hut_text">
                <p class="hutIDtext" style="margin: 0;"> Hut ID: </p>
            </div>
            <div class="hut_id">
                <p class="hutIDgen" style="margin: 0;" name="hutIDgen" >####</p>
                <input class="hiddenInput" name="hutIDgenInput" type="hidden">
            </div>
        </div>
        <div class="hut_tickets">
            <div class="hutForm">
                <label class="person-input" for="person1"><b>Spot #1:</b></label>
                <input class="inputN1" type="number" value="" placeholder="First Person Ticket ID" name="person1">

                <label class="person-input" for="person2"><b>Spot #2:</b></label>
                <input class="inputN2" type="number" value="" placeholder="Second Person Ticket ID" name="person2">

                <label class="person-input" for="person3"><b>Spot #3:</b></label>
                <input class="inputN3" type="number" value="" placeholder="Third Person Ticket ID" name="person3">

                <label class="person-input" for="person4"><b>Spot #4:</b></label>
                <input class="inputN4" type="number" value="" placeholder="Fourth Person Ticket ID" name="person4">
                <div class="submitBtn">
                    <button class="addPersonsHut" type="submit" name="addPersonsHut">ADD</button>
                </div>
            </div>
        </div>
    </form>
</div>
