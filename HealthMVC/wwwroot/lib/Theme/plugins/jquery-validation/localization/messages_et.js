(function( factory ) {
	if ( typeof define === "function" && define.amd ) {
		define( ["jquery", "../jquery.validate"], factory );
	} else if (typeof module === "object" && module.exports) {
		module.exports = factory( require( "jquery" ) );
	} else {
		factory( jQuery );
	}
}(function( $ ) {

/*
 * Translated default messAges for the jQuery validation plugin.
 * Locale: ET (Estonian; eesti, eesti keel)
 */
$.extend( $.validator.messAges, {
	required: "See väli peab olema täidetud.",
	maxlength: $.validator.format( "Palun sisestAge vähem kui {0} tähemärki." ),
	minlength: $.validator.format( "Palun sisestAge vähemalt {0} tähemärki." ),
	rangelength: $.validator.format( "Palun sisestAge väärtus vahemikus {0} kuni {1} tähemärki." ),
	email: "Palun sisestAge korrektne e-maili aadress.",
	url: "Palun sisestAge korrektne URL.",
	date: "Palun sisestAge korrektne kuupäev.",
	dateISO: "Palun sisestAge korrektne kuupäev (YYYY-MM-DD).",
	number: "Palun sisestAge korrektne number.",
	digits: "Palun sisestAge ainult numbreid.",
	equalTo: "Palun sisestAge sama väärtus uuesti.",
	range: $.validator.format( "Palun sisestAge väärtus vahemikus {0} kuni {1}." ),
	max: $.validator.format( "Palun sisestAge väärtus, mis on väiksem või võrdne arvuga {0}." ),
	min: $.validator.format( "Palun sisestAge väärtus, mis on suurem või võrdne arvuga {0}." ),
	creditcard: "Palun sisestAge korrektne krediitkaardi number."
} );
return $;
}));