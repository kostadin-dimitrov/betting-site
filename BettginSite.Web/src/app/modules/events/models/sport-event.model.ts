export interface SportEvent {
    id: string,
    eventId: number;
    name: string;
    homeTeamOdds: number;
    awayTeamOdds: number;
    drawOdds: number;
    startDate: Date;
}
