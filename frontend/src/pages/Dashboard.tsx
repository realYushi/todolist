import { Card, OverviewCard } from "../components/Card";
import { faUser } from "@fortawesome/free-regular-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

export function Dashboard() {
    return (
        <section>
            <OverviewCard totalNumber={1234} />
            <Card
                title="Users"
                icon={<FontAwesomeIcon icon={faUser} size="lg" />}
                number={1234}
            />
            <Card
                title="Users"
                icon={<FontAwesomeIcon icon={faUser} size="lg" />}
                number={1234}
            />
            <Card
                title="Users"
                icon={<FontAwesomeIcon icon={faUser} size="lg" />}
                number={1234}
            />
            <Card
                title="Users"
                icon={<FontAwesomeIcon icon={faUser} size="lg" />}
                number={1234}
            />
        </section>
    );
}
