namespace DurakClient
{
    partial class DurakClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameDeck = new System.Windows.Forms.Label();
            this.lblHumanPlayer = new System.Windows.Forms.Label();
            this.lblComputerPlayer = new System.Windows.Forms.Label();
            this.lblRiver = new System.Windows.Forms.Label();
            this.lblComputerAttacking = new System.Windows.Forms.Label();
            this.lblHumanAttacking = new System.Windows.Forms.Label();
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.flpComputerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRiver = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHumanHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTrumpCard = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDiscardPile = new System.Windows.Forms.Label();
            this.flpDiscardPile = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDeckCardsRemaining = new System.Windows.Forms.TextBox();
            this.txtDicardCardsRemaining = new System.Windows.Forms.TextBox();
            this.txtRiverCardsRemaning = new System.Windows.Forms.TextBox();
            this.btnCeaseAttack = new System.Windows.Forms.Button();
            this.btn36Deck = new System.Windows.Forms.Button();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.txtRoundNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGameDeck
            // 
            this.lblGameDeck.AutoSize = true;
            this.lblGameDeck.BackColor = System.Drawing.Color.Lime;
            this.lblGameDeck.Location = new System.Drawing.Point(38, 165);
            this.lblGameDeck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameDeck.Name = "lblGameDeck";
            this.lblGameDeck.Size = new System.Drawing.Size(61, 13);
            this.lblGameDeck.TabIndex = 0;
            this.lblGameDeck.Text = "GameDeck";
            // 
            // lblHumanPlayer
            // 
            this.lblHumanPlayer.AutoSize = true;
            this.lblHumanPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHumanPlayer.Location = new System.Drawing.Point(839, 525);
            this.lblHumanPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumanPlayer.Name = "lblHumanPlayer";
            this.lblHumanPlayer.Size = new System.Drawing.Size(103, 13);
            this.lblHumanPlayer.TabIndex = 1;
            this.lblHumanPlayer.Text = "Human Player Cards";
            // 
            // lblComputerPlayer
            // 
            this.lblComputerPlayer.AutoSize = true;
            this.lblComputerPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblComputerPlayer.Location = new System.Drawing.Point(839, 74);
            this.lblComputerPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputerPlayer.Name = "lblComputerPlayer";
            this.lblComputerPlayer.Size = new System.Drawing.Size(114, 13);
            this.lblComputerPlayer.TabIndex = 2;
            this.lblComputerPlayer.Text = "Computer Player Cards";
            // 
            // lblRiver
            // 
            this.lblRiver.AutoSize = true;
            this.lblRiver.BackColor = System.Drawing.Color.Lime;
            this.lblRiver.Location = new System.Drawing.Point(839, 266);
            this.lblRiver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiver.Name = "lblRiver";
            this.lblRiver.Size = new System.Drawing.Size(62, 13);
            this.lblRiver.TabIndex = 3;
            this.lblRiver.Text = "River Cards";
            // 
            // lblComputerAttacking
            // 
            this.lblComputerAttacking.AutoEllipsis = true;
            this.lblComputerAttacking.AutoSize = true;
            this.lblComputerAttacking.BackColor = System.Drawing.Color.Red;
            this.lblComputerAttacking.Location = new System.Drawing.Point(839, 60);
            this.lblComputerAttacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputerAttacking.Name = "lblComputerAttacking";
            this.lblComputerAttacking.Size = new System.Drawing.Size(100, 13);
            this.lblComputerAttacking.TabIndex = 4;
            this.lblComputerAttacking.Text = "Computer Attacking";
            // 
            // lblHumanAttacking
            // 
            this.lblHumanAttacking.AutoSize = true;
            this.lblHumanAttacking.BackColor = System.Drawing.Color.Red;
            this.lblHumanAttacking.Location = new System.Drawing.Point(839, 539);
            this.lblHumanAttacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumanAttacking.Name = "lblHumanAttacking";
            this.lblHumanAttacking.Size = new System.Drawing.Size(89, 13);
            this.lblHumanAttacking.TabIndex = 5;
            this.lblHumanAttacking.Text = "Human Attacking";
            // 
            // lblTrumpCard
            // 
            this.lblTrumpCard.AutoSize = true;
            this.lblTrumpCard.BackColor = System.Drawing.Color.Lime;
            this.lblTrumpCard.Location = new System.Drawing.Point(38, 321);
            this.lblTrumpCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrumpCard.Name = "lblTrumpCard";
            this.lblTrumpCard.Size = new System.Drawing.Size(62, 13);
            this.lblTrumpCard.TabIndex = 6;
            this.lblTrumpCard.Text = "Trump Card";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(29, 91);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(104, 39);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start/New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(941, 249);
            this.btnPickUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(56, 54);
            this.btnPickUp.TabIndex = 8;
            this.btnPickUp.Text = "Pick Up River Cards";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // flpComputerHand
            // 
            this.flpComputerHand.BackColor = System.Drawing.Color.Transparent;
            this.flpComputerHand.Location = new System.Drawing.Point(270, 17);
            this.flpComputerHand.Margin = new System.Windows.Forms.Padding(2);
            this.flpComputerHand.Name = "flpComputerHand";
            this.flpComputerHand.Size = new System.Drawing.Size(555, 197);
            this.flpComputerHand.TabIndex = 9;
            // 
            // flpRiver
            // 
            this.flpRiver.BackColor = System.Drawing.Color.Transparent;
            this.flpRiver.Location = new System.Drawing.Point(270, 219);
            this.flpRiver.Margin = new System.Windows.Forms.Padding(2);
            this.flpRiver.Name = "flpRiver";
            this.flpRiver.Size = new System.Drawing.Size(555, 222);
            this.flpRiver.TabIndex = 10;
            // 
            // flpHumanHand
            // 
            this.flpHumanHand.BackColor = System.Drawing.Color.Transparent;
            this.flpHumanHand.Location = new System.Drawing.Point(270, 445);
            this.flpHumanHand.Margin = new System.Windows.Forms.Padding(2);
            this.flpHumanHand.Name = "flpHumanHand";
            this.flpHumanHand.Size = new System.Drawing.Size(555, 214);
            this.flpHumanHand.TabIndex = 11;
            // 
            // flpDeck
            // 
            this.flpDeck.BackColor = System.Drawing.Color.Transparent;
            this.flpDeck.Location = new System.Drawing.Point(29, 192);
            this.flpDeck.Margin = new System.Windows.Forms.Padding(2);
            this.flpDeck.Name = "flpDeck";
            this.flpDeck.Size = new System.Drawing.Size(99, 111);
            this.flpDeck.TabIndex = 12;
            // 
            // flpTrumpCard
            // 
            this.flpTrumpCard.BackColor = System.Drawing.Color.Transparent;
            this.flpTrumpCard.Location = new System.Drawing.Point(28, 371);
            this.flpTrumpCard.Margin = new System.Windows.Forms.Padding(2);
            this.flpTrumpCard.Name = "flpTrumpCard";
            this.flpTrumpCard.Size = new System.Drawing.Size(99, 111);
            this.flpTrumpCard.TabIndex = 13;
            // 
            // lblDiscardPile
            // 
            this.lblDiscardPile.AutoSize = true;
            this.lblDiscardPile.BackColor = System.Drawing.Color.Lime;
            this.lblDiscardPile.Location = new System.Drawing.Point(38, 505);
            this.lblDiscardPile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscardPile.Name = "lblDiscardPile";
            this.lblDiscardPile.Size = new System.Drawing.Size(60, 13);
            this.lblDiscardPile.TabIndex = 14;
            this.lblDiscardPile.Text = "DiscardPile";
            // 
            // flpDiscardPile
            // 
            this.flpDiscardPile.BackColor = System.Drawing.Color.Transparent;
            this.flpDiscardPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpDiscardPile.Location = new System.Drawing.Point(29, 539);
            this.flpDiscardPile.Margin = new System.Windows.Forms.Padding(2);
            this.flpDiscardPile.Name = "flpDiscardPile";
            this.flpDiscardPile.Size = new System.Drawing.Size(99, 101);
            this.flpDiscardPile.TabIndex = 15;
            // 
            // txtDeckCardsRemaining
            // 
            this.txtDeckCardsRemaining.Location = new System.Drawing.Point(142, 236);
            this.txtDeckCardsRemaining.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeckCardsRemaining.Name = "txtDeckCardsRemaining";
            this.txtDeckCardsRemaining.ReadOnly = true;
            this.txtDeckCardsRemaining.Size = new System.Drawing.Size(18, 20);
            this.txtDeckCardsRemaining.TabIndex = 16;
            // 
            // txtDicardCardsRemaining
            // 
            this.txtDicardCardsRemaining.Location = new System.Drawing.Point(142, 578);
            this.txtDicardCardsRemaining.Margin = new System.Windows.Forms.Padding(2);
            this.txtDicardCardsRemaining.Name = "txtDicardCardsRemaining";
            this.txtDicardCardsRemaining.ReadOnly = true;
            this.txtDicardCardsRemaining.Size = new System.Drawing.Size(18, 20);
            this.txtDicardCardsRemaining.TabIndex = 17;
            // 
            // txtRiverCardsRemaning
            // 
            this.txtRiverCardsRemaning.Location = new System.Drawing.Point(910, 266);
            this.txtRiverCardsRemaning.Margin = new System.Windows.Forms.Padding(2);
            this.txtRiverCardsRemaning.Name = "txtRiverCardsRemaning";
            this.txtRiverCardsRemaning.ReadOnly = true;
            this.txtRiverCardsRemaning.Size = new System.Drawing.Size(18, 20);
            this.txtRiverCardsRemaning.TabIndex = 18;
            // 
            // btnCeaseAttack
            // 
            this.btnCeaseAttack.Location = new System.Drawing.Point(940, 321);
            this.btnCeaseAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnCeaseAttack.Name = "btnCeaseAttack";
            this.btnCeaseAttack.Size = new System.Drawing.Size(59, 52);
            this.btnCeaseAttack.TabIndex = 19;
            this.btnCeaseAttack.Text = "Cease Attack";
            this.btnCeaseAttack.UseVisualStyleBackColor = true;
            this.btnCeaseAttack.Click += new System.EventHandler(this.btnCeaseAttack_Click);
            // 
            // btn36Deck
            // 
            this.btn36Deck.Location = new System.Drawing.Point(28, 11);
            this.btn36Deck.Margin = new System.Windows.Forms.Padding(2);
            this.btn36Deck.Name = "btn36Deck";
            this.btn36Deck.Size = new System.Drawing.Size(64, 19);
            this.btn36Deck.TabIndex = 21;
            this.btn36Deck.Text = "36 Deck";
            this.btn36Deck.UseVisualStyleBackColor = true;
            this.btn36Deck.Click += new System.EventHandler(this.btn36Deck_Click);
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Lime;
            this.lblRoundNumber.Location = new System.Drawing.Point(839, 11);
            this.lblRoundNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(79, 13);
            this.lblRoundNumber.TabIndex = 25;
            this.lblRoundNumber.Text = "Round Number";
            // 
            // txtRoundNumber
            // 
            this.txtRoundNumber.Location = new System.Drawing.Point(921, 8);
            this.txtRoundNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoundNumber.Name = "txtRoundNumber";
            this.txtRoundNumber.ReadOnly = true;
            this.txtRoundNumber.Size = new System.Drawing.Size(18, 20);
            this.txtRoundNumber.TabIndex = 26;
            // 
            // DurakClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakClient.Properties.Resources.test2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 670);
            this.Controls.Add(this.txtRoundNumber);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.btn36Deck);
            this.Controls.Add(this.btnCeaseAttack);
            this.Controls.Add(this.txtRiverCardsRemaning);
            this.Controls.Add(this.txtDicardCardsRemaining);
            this.Controls.Add(this.txtDeckCardsRemaining);
            this.Controls.Add(this.flpDiscardPile);
            this.Controls.Add(this.lblDiscardPile);
            this.Controls.Add(this.flpTrumpCard);
            this.Controls.Add(this.flpDeck);
            this.Controls.Add(this.flpHumanHand);
            this.Controls.Add(this.flpRiver);
            this.Controls.Add(this.flpComputerHand);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblTrumpCard);
            this.Controls.Add(this.lblHumanAttacking);
            this.Controls.Add(this.lblComputerAttacking);
            this.Controls.Add(this.lblRiver);
            this.Controls.Add(this.lblComputerPlayer);
            this.Controls.Add(this.lblHumanPlayer);
            this.Controls.Add(this.lblGameDeck);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DurakClientForm";
            this.Text = "DurakClient";
            this.Load += new System.EventHandler(this.DurakClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDeck;
        private System.Windows.Forms.Label lblHumanPlayer;
        private System.Windows.Forms.Label lblComputerPlayer;
        private System.Windows.Forms.Label lblRiver;
        private System.Windows.Forms.Label lblComputerAttacking;
        private System.Windows.Forms.Label lblHumanAttacking;
        private System.Windows.Forms.Label lblTrumpCard;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.FlowLayoutPanel flpComputerHand;
        private System.Windows.Forms.FlowLayoutPanel flpRiver;
        private System.Windows.Forms.FlowLayoutPanel flpHumanHand;
        private System.Windows.Forms.FlowLayoutPanel flpDeck;
        private System.Windows.Forms.FlowLayoutPanel flpTrumpCard;
        private System.Windows.Forms.Label lblDiscardPile;
        private System.Windows.Forms.FlowLayoutPanel flpDiscardPile;
        private System.Windows.Forms.TextBox txtDeckCardsRemaining;
        private System.Windows.Forms.TextBox txtDicardCardsRemaining;
        private System.Windows.Forms.TextBox txtRiverCardsRemaning;
        private System.Windows.Forms.Button btnCeaseAttack;
        private System.Windows.Forms.Button btn36Deck;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.TextBox txtRoundNumber;
    }
}