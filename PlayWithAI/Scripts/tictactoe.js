var isXsTurn = false;
var xBlock = '<i class="fa fa-4x fa-close"></i>';
var oBlock = '<i class="fa fa-4x fa-circle-o"></i>';

$(document).ready(function () {
    $('#game-board tr td').mouseenter(function () {
        var isBlockEmpty = $(this).find('.marked').length === 0;

        if (isBlockEmpty) {
            if (isXsTurn) {
                $(this).html(xBlock);
            } else {
                $(this).html(oBlock);
            }
        }
    });

    $('#game-board tr td').mouseleave(function () {
        var isBlockEmpty = $(this).find('.marked').length === 0;

        if (isBlockEmpty) {
            if (isXsTurn) {
                $(this).html('');
            } else {
                $(this).html('');
            }
        }
    });

    $('#game-board tr td').click(function () {
        var block = $(this).find('i');

        if (block.length !== 0) {
            if (!block.hasClass('marked')) {
                block.addClass('marked');
                isXsTurn = !isXsTurn;
                getBotMove(block.prop('data-row'), block.prop('data-col'));
            }
        }
    });
});

function getBotMove(row, col) {
    $.post('/TicTacToe', {
        row: row,
        col: col,
    }, getBotMoveCallback);
}

function getBotMoveCallback(data) {
    alert('inside callback');
}