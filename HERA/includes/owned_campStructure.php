<div class="campbox non-printable">
    <form class="camp_info" action="includes/addTickets.php" method="post">
        <div class="camp_idbox">
            <div class="camp_text">
                <p class="campIDtext" style="margin: 0;">Camping Spot ID: </p>
            </div>
            <div class="camp_id">
                <p class="campIDgen" style="margin: 0;">####</p>
                <input class="hiddenInputCamp" name="campIDgenInput" type="hidden">
            </div>
        </div>
        <div class="camp_tickets">
            <div  class="campForm">
                <div style="display: flex; flex-direction: column;">
                    <div style="display: block; margin: 0 auto;">
                        <label class="person-input" for="person1"><b>Spot #1:</b></label>
                        <input class="inputNcamp1" type="number" placeholder="First Person Ticket ID" name="firstPCamp">
                    </div>
                    <div style="display: block; padding-top: 5px; margin: 0 auto;">
                        <label class="person-input" for="person2"><b>Spot #2:</b></label>
                        <input class="inputNcamp2" type="number" placeholder="Second Person Ticket ID" name="secondPCamp">
                    </div>
                </div>
                <div class="submitBtn">
                    <button class = "addPersonsCamp" type="submit" name="addPersonsCamp">ADD</button>
                </div>
            </div>
        </div>
    </form>
</div>

