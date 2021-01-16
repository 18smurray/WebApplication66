//JavaScript for the Grade Calculator

//Identifies submit button
var submit = document.getElementById("SubmitButton");

//When submit button is clicked, multiply each grade category percent input by the appropriate percent of the final grade
//and determine the letter grade based on the final percent
//Uses an alert to display the final percent and letter grade
submit.addEventListener("click", function () {

    //Calculate weighted percent of each grade category
    var assignment_pct = document.getElementById("assignment").value * 0.5;
    var group_pct = document.getElementById("group").value * 0.1;
    var quiz_pct = document.getElementById("quiz").value * 0.1;
    var exam_pct = document.getElementById("exam").value * 0.2;
    var intex_pct = document.getElementById("intex").value * 0.1;

    //Calculate final grade by adding all weighted grade category percentages
    var finalgrade = assignment_pct + group_pct + quiz_pct + exam_pct + intex_pct;

    var lettergrade = "";

    //Determine the letter grade based on the final grade percentage
    if (finalgrade >= 94) {
        lettergrade = "A";
    } else if (finalgrade >= 90) {
        lettergrade = "A-";
    } else if (finalgrade >= 87) {
        lettergrade = "B+";
    } else if (finalgrade >= 84) {
        lettergrade = "B";
    } else if (finalgrade >= 80) {
        lettergrade = "B-";
    } else if (finalgrade >= 77) {
        lettergrade = "C+";
    } else if (finalgrade >= 74) {
        lettergrade = "C";
    } else if (finalgrade >= 70) {
        lettergrade = "C-";
    } else if (finalgrade >= 67) {
        lettergrade = "D+";
    } else if (finalgrade >= 64) {
        lettergrade = "D";
    } else if (finalgrade >= 60) {
        lettergrade = "D-";
    } else {
        lettergrade = "F";
    }

    //Alert the final percentage and letter grade
    alert("Final Percentage: " + finalgrade + "%" + "\n" + "Letter Grade: " + lettergrade);
});