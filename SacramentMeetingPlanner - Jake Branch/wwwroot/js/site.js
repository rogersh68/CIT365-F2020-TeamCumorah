// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
document.addEventListener("DOMContentLoaded", function () {

    if (!(document.getElementById("addSpeakerButton") === null)) {

        document.getElementById("addSpeakerButton").addEventListener("click", function () {

            //build a new speakers-group
            var speakersGroup = document.createElement("DIV");
            speakersGroup.setAttribute("class", "speakers-group");

            //speaker
            var formGroup1 = document.createElement("DIV");
            formGroup1.setAttribute("class", "form-group");

            //speaker label
            var speakerLabel = document.createElement("LABEL");
            speakerLabel.setAttribute("asp-for", "SacramentProgram.Speakers");
            speakerLabel.setAttribute("class", "control-label");
            speakerLabel.textContent = "Speaker";

            //speaker input
            var speakerInput = document.createElement("INPUT");
            speakerInput.setAttribute("asp-for", "SacramentProgram.Speakers");
            speakerInput.setAttribute("name", "speakerName");
            speakerInput.setAttribute("class", "form-control");

            //speaker span
            var speakerSpan = document.createElement("SPAN");
            speakerSpan.setAttribute("asp-validation-for", "SacramentProgram.Speakers");
            speakerSpan.setAttribute("class", "text-danger");

            //merge speaker
            formGroup1.appendChild(speakerLabel);
            formGroup1.appendChild(speakerInput);
            formGroup1.appendChild(speakerSpan);

            //subject
            var formGroup2 = document.createElement("DIV");
            formGroup2.setAttribute("class", "form-group");

            //subject label
            var subjectLabel = document.createElement("LABEL");
            subjectLabel.setAttribute("asp-for", "SacramentProgram.SpeakerSubjects");
            subjectLabel.setAttribute("class", "control-label");
            subjectLabel.textContent = "Speaker Subject"

            //subject input
            var subjectInput = document.createElement("INPUT");
            subjectInput.setAttribute("asp-for", "SacramentProgram.SpeakerSubjects");
            subjectInput.setAttribute("name", "speakerSubject");
            subjectInput.setAttribute("class", "form-control");

            //subject span
            var subjectSpan = document.createElement("SPAN");
            subjectSpan.setAttribute("asp-validation-for", "SacramentProgram.SpeakerSubjects");
            subjectSpan.setAttribute("class", "text-danger");

            //merge subject
            formGroup2.appendChild(subjectLabel);
            formGroup2.appendChild(subjectInput);
            formGroup2.appendChild(subjectSpan);

            //merge all
            speakersGroup.appendChild(formGroup1);
            speakersGroup.appendChild(formGroup2);

            var form = document.getElementsByTagName("FORM")[0];
            var formChildren = form.children;
            form.insertBefore(speakersGroup, formChildren[formChildren.length - 3]);

        });
    }
});

