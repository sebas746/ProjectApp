export class Policy {

    public constructor(init?: Partial<Policy>) {
        Object.assign(this, init);
    }

    PolicyId: number;
    PolicyName: string;
    PolicyDescription: string;
    PolicyPeriod: number;
    PolicyPrice: number;
    RiskTypeId: number;
    CoverageTypeId: number;
    PolicyStartDate: string;    
}